namespace MigrationUtils.Dal.Models
{
    public class Swot : Audit
    {
        public int SwotId { get; set; }

        public string SwotTypeId { get; set; }

        public int ProjectId { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }
    }
}