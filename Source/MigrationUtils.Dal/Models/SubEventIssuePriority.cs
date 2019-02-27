namespace MigrationUtils.Dal.Models
{
    public class SubEventIssuePriority : Audit
    {
        public int SubEventId { get; set; }

        public string IssuePriorityTypeId { get; set; }

    }
}