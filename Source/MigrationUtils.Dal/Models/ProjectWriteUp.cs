namespace MigrationUtils.Dal.Models
{
    public class ProjectWriteUp : Audit
    {
        public int ProjectId { get; set; }

        public string ProposalWriteUpTypeId { get; set; }

        public bool IsDeleted { get; set; }

        public string Description { get; set; }
    }
}