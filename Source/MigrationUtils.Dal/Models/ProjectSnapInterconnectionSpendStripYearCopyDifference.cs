namespace MigrationUtils.Dal.Models
{
    public class ProjectSnapInterconnectionSpendStripYearCopyDifference : Audit
    {
        public int ProjectSnapInterconnectionSpendStripYearCopyDifferenceId { get; set; }

        public int ProjectSnapInterconnectionSpendStripId { get; set; }

        public int Year { get; set; }

        public bool? NeedsAction { get; set; }

        public string Description { get; set; }
    }
}