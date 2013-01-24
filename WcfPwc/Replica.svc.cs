using System;
using System.Data;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WcfPwc.SeecWebReference;


namespace WcfPwc
{
    public class Replica : IReplica
    {

        public SeecObject SincronizaIpad(Stream stream)
        {

            //var w = File.AppendText(@"c:\server2ipad.txt");

            StreamReader sr = new StreamReader(stream);
            string jsonString = sr.ReadToEnd();

            jsonString = "{\"evaluation\":" + jsonString + "}";
            //Log
            //Log(jsonString, w);

            IEnumerable<Evaluation> EvalToSend;
            var EvalInServer = new List<Evaluation>();
            var RequestEvaluation = new wsReply();

            SeecObject ObjectToIpad = new SeecObject();
            if (jsonString.Any())
            {
                SeecObject ObjectFromIpad = JsonConvert.DeserializeObject<SeecObject>(jsonString);

                int branchId = Convert.ToInt32(ObjectFromIpad.evaluation[0].fK_branchId);
                int phase = Convert.ToInt32(ObjectFromIpad.evaluation[0].phaseNum);

                DataSet dataSet = RequestEvaluation.dataFromWeb(branchId, phase);
                DataTable dataTable = dataSet.Tables[0];
                // Extraemos la informacion del SERVIDOR a una lista de evaluaciones
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    Evaluation tmp = new Evaluation();
                    tmp.lK_evaluationId = dataRow["LK_evaluationId"].ToString();
                    tmp.fK_userId = dataRow["FK_userId"].ToString();
                    tmp.fK_manualId = dataRow["FK_manualId"].ToString();
                    tmp.fK_standardId = dataRow["FK_standardId"].ToString();
                    tmp.fK_activityId = dataRow["FK_activityId"].ToString();
                    tmp.fK_branchId = dataRow["FK_branchId"].ToString();
                    tmp.fK_departmentId = dataRow["FK_departmentId"].ToString();
                    tmp.fK_ownerId = dataRow["FK_ownerId"].ToString();
                    tmp.phaseNum = dataRow["phaseNum"].ToString();
                    tmp.reached = dataRow["reached"].ToString();
                    tmp.notReached = dataRow["notReached"].ToString();
                    tmp.certificationLevel = dataRow["certificationLevel"].ToString();
                    tmp.commentTitle = dataRow["commentTitle"].ToString();
                    tmp.comment = dataRow["comment"].ToString();
                    tmp.recommendation = dataRow["recommendation"].ToString();
                    tmp.createdDate = dataRow["createdDate"].ToString();
                    tmp.tracking = dataRow["tracking"].ToString();
                    tmp.specialStandard = dataRow["specialStandard"].ToString();
                    EvalInServer.Add(tmp);
                }

                EvalToSend = EvalInServer.Except(ObjectFromIpad.evaluation, new EvaluationComparer());
                ObjectToIpad.evaluation = EvalToSend.ToArray();
            }
            return ObjectToIpad;

        }


        public ResponseObject SincronizaServer(Stream stream)
        {
            var sr = new StreamReader(stream);
            //var w = File.AppendText(@"c:\ipad2server.txt");

            string jsonString = sr.ReadToEnd();
            //Log(jsonString, w);
            jsonString = "{\"evaluation\":" + jsonString + "}";
            string query;
            string resultQuery;

            int branchId;
            int phase;
            int numErrores = 0;
            int numRegInsertados = 0;

            DataTable dataTable;
            DataSet dataSet;
            IEnumerable<Evaluation> EvalToInsert;

            var RequestEvaluation = new wsReply();
            var ObjectFromIpad = JsonConvert.DeserializeObject<SeecObject>(jsonString);
            var response = new ResponseObject();

            var EvalInServer = new List<Evaluation>();
            var EvaiInIpad = ObjectFromIpad.evaluation.ToList();

            foreach (var obj in EvaiInIpad)
            {
                branchId = Convert.ToInt32(obj.fK_branchId);
                phase = Convert.ToInt32(obj.phaseNum);

                dataSet = RequestEvaluation.dataFromWeb(branchId, phase);
                dataTable = dataSet.Tables[0];
                // Extraemos la informacion del SERVIDOR a una lista de evaluaciones
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    var tmp = new Evaluation
                                  {
                                      lK_evaluationId = dataRow["LK_evaluationId"].ToString(),
                                      fK_userId = dataRow["FK_userId"].ToString(),
                                      fK_manualId = dataRow["FK_manualId"].ToString(),
                                      fK_standardId = dataRow["FK_standardId"].ToString(),
                                      fK_activityId = dataRow["FK_activityId"].ToString(),
                                      fK_branchId = dataRow["FK_branchId"].ToString(),
                                      fK_departmentId = dataRow["FK_departmentId"].ToString(),
                                      fK_ownerId = dataRow["FK_ownerId"].ToString(),
                                      phaseNum = dataRow["phaseNum"].ToString(),
                                      reached = dataRow["reached"].ToString(),
                                      notReached = dataRow["notReached"].ToString(),
                                      certificationLevel = dataRow["certificationLevel"].ToString(),
                                      commentTitle = dataRow["commentTitle"].ToString(),
                                      comment = dataRow["comment"].ToString(),
                                      recommendation = dataRow["recommendation"].ToString(),
                                      createdDate = dataRow["createdDate"].ToString(),
                                      tracking = dataRow["tracking"].ToString(),
                                      specialStandard = dataRow["specialStandard"].ToString()
                                  };
                    EvalInServer.Add(tmp);

                }

            }

            EvalToInsert = EvaiInIpad.Except(EvalInServer, new EvaluationComparer());

            foreach (var evaluation in EvalToInsert)
            {
                query = RequestEvaluation.insertToWeb(
                    Convert.ToInt32(evaluation.fK_userId),
                    Convert.ToInt32(evaluation.fK_manualId),
                    Convert.ToInt32(evaluation.fK_standardId),
                    Convert.ToInt32(evaluation.fK_activityId),
                    Convert.ToInt32(evaluation.fK_branchId),
                    Convert.ToInt32(evaluation.fK_departmentId),
                    Convert.ToInt32(evaluation.fK_ownerId),
                    Convert.ToInt32(evaluation.phaseNum),
                    Convert.ToInt32(evaluation.reached),
                    Convert.ToInt32(evaluation.notReached),
                    Convert.ToInt32(evaluation.notApplicable),
                    evaluation.certificationLevel,
                    evaluation.commentTitle,
                    evaluation.comment,
                    evaluation.recommendation,
                    DateTime.Parse(evaluation.createdDate),
                    Convert.ToInt32(evaluation.fK_standardId));

                //Insertamos en el servidor
                resultQuery = RequestEvaluation.openExecuteFromLocal(query);
                //  Log("Query: " + query, w);

                if (resultQuery == "done")
                {
                    numRegInsertados++;
                }
                else
                {
                    numErrores++;
                }

            }

            response.numErrores = numErrores;
            response.numRegInsertados = numRegInsertados;
            response.numRegProcesados = EvaiInIpad.Count;

            //Log(response.ToString(), w);
            return response;
        }

        private static void Log(string msg, TextWriter w)
        {
            w.Write("\r\nLog  : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", msg);
            w.WriteLine("-------------------------------");
            w.Flush();
        }



        public BranchObject GetBranchs(int phase)
        {
            var Request = new wsReply();
            var BranchToSend = new BranchObject();

            DataSet dataSet = Request.distFromWeb(phase);
            DataTable dataTable = dataSet.Tables[0];
            var listBranch = new List<Branch>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                var tmp = new Branch
                              {
                                  branchId = Convert.ToInt32(dataRow["FK_branchId"]),
                                  branchName = dataRow["branchName"].ToString(),
                                  phaseNum = Convert.ToInt32(dataRow["phaseNum"].ToString())
                              };
                listBranch.Add(tmp);
            }

            BranchToSend.branchs = listBranch.ToArray();
            return BranchToSend;
        }

        public PhaseObject GetPhases()
        {
            var Request = new wsReply();
            var PhaseToSend = new PhaseObject();
            var listPhases = new List<Phase>();
            DataSet dataSet = Request.phaseFromWeb();
            DataTable dataTable = dataSet.Tables[0];

            foreach (DataRow dataRow in dataTable.Rows)
            {
                var tmp = new Phase
                              {
                                  phaseNum = Convert.ToInt32(dataRow["phaseNum"])
                              };
                listPhases.Add(tmp);
            }

            PhaseToSend.phases = listPhases.ToArray();
            return PhaseToSend;
        }
    }
}
