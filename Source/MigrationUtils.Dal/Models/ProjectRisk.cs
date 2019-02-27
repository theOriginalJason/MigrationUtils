namespace MigrationUtils.Dal.Models
{
    public class ProjectRisk : Audit
    {
        public int ProjectRiskId { get; set; }

        public int ProjectId { get; set; }

        public string ProjectRiskCategory { get; set; }

        public string ProjectRiskLevel { get; set; }

        public bool IsDeleted { get; set; }
    }
}