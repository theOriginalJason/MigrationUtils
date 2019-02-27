namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectRisk : Audit
    {
        public int NewStartProjectRiskId { get; set; }

        public int NewStartProjectId { get; set; }

        public string ProjectRiskCategory { get; set; }

        public string ProjectRiskLevel { get; set; }
    }
}