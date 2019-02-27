namespace MigrationUtils.Dal.Models
{
    public class ProjectLlc:Audit
    {
        public int ProjectLlcId { get; set; }

        public string Name { get; set; }

        public string DaxId { get; set; }

        public string FormationState { get; set; }

        public string QualificationState { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsShelfEntity { get; set; }

        public string FormationStatus { get; set; }

        public string QualificationStatus { get; set; }
    }
}