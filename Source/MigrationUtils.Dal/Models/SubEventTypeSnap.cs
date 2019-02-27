namespace MigrationUtils.Dal.Models
{
    public class SubEventTypeSnap
    {
        public int SnapId { get; set; }

        public int SubEventTypeId { get; set; }

        public string Name { get; set; }

        public bool IsMonetary { get; set; }

        public string EventTypeDesignation { get; set; }

        public string Description { get; set; }

        public string MonetaryType { get; set; }

        public bool IsAmountNegative { get; set; }

        public bool ProjectIssueDisplay { get; set; }
    }
}