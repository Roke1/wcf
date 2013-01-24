namespace WcfPwc
{

    public class Evaluation
    {

        public string lK_evaluationId { get; set; }

        public string fK_userId { get; set; }

        public string fK_manualId { get; set; }

        public string fK_standardId { get; set; }

        public string fK_activityId { get; set; }

        public string fK_branchId { get; set; }

        public string fK_departmentId { get; set; }

        public string fK_ownerId { get; set; }

        public string phaseNum { get; set; }

        public string reached { get; set; }

        public string notReached { get; set; }

        public string notApplicable { get; set; }

        public string certificationLevel { get; set; }

        public string commentTitle { get; set; }

        public string comment { get; set; }

        public string recommendation { get; set; }

        public string createdDate { get; set; }

        public string tracking { get; set; }

        public string specialStandard { get; set; }

        // Estos no vienen en el webservice

        public string actionPlanApprove { get; set; }

        public string furtherContribution { get; set; }

        public string actionPlan { get; set; }

        public string commentDate { get; set; }

        public string actionPlanComment { get; set; }

        public string estimatedImpDate { get; set; }

        public string actionPlanDate { get; set; }
    }
}