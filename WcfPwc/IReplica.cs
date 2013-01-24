using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPwc
{
    [ServiceContract]
    public interface IReplica
    {
        /// <summary>
        /// Recibo JSON como stream mediante POST y sincronizo los datos del server al ipad
        /// </summary>
        /// <param name="stream">Stream que contiene el Json con los datos del ipad</param>
        /// <returns>Json que contiene las evaluaciones que estan en el servidor y que no se encuentran en el iPad</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/server2ipad",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        SeecObject SincronizaIpad(Stream stream);

        /// <summary>
        /// Recibo JSON como stream mediante POST y sincronizo insertando los datos al servidor
        /// </summary>
        /// <param name="stream">Stream que contiene el Json con los datos del ipad</param>
        /// <returns>Json con el sumario de los registros procesados, los errores que ocurrieron al insertar, el numero de registros insertados exitosamente</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/ipad2server",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        ResponseObject SincronizaServer(Stream stream);

        /// <summary>
        /// Actualiza el catalogo de branchs con los datos del servidor
        /// </summary>
        /// <returns>Json con los datos de branch</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/branch",
            Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        BranchObject GetBranchs(int phase);

        /// <summary>
        /// ACtualiza el catalogo de las phases con datos del server
        /// </summary>
        /// <param name="phase">Id de phase</param>
        /// <returns>Json con los datos de branch que pertenecen a determinada phase</returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/phase",
            Method = "POST",
            ResponseFormat = WebMessageFormat.Json)]
        PhaseObject GetPhases();
    }

    [DataContract]
    public class SeecObject
    {
        [DataMember]
        public Evaluation[] evaluation { get; set; }
    }

    [DataContract]
    public class BranchObject
    {
        [DataMember]
        public Branch[] branchs { get; set; }
    }

    [DataContract]
    public class PhaseObject
    {
        [DataMember]
        public Phase[] phases { get; set; }
    }

    [DataContract]
    public class ResponseObject
    {
        [DataMember]
        public int numRegInsertados { get; set; }
        [DataMember]
        public int numRegProcesados { get; set; }
        [DataMember]
        public int numErrores { get; set; }
    }
}
