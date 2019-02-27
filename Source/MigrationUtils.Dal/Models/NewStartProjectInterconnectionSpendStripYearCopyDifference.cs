namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectInterconnectionSpendStripYearCopyDifference :Audit
    {
        public int NewStartProjectInterconnectionSpendStripYearCopyDifferenceId { get; set; }

        public int NewStartProjectInterconnectionSpendStripId { get; set; }

        public int Year { get; set; }

        public bool? NeedsAction { get; set; }

        public string Description { get; set; }
    }
}