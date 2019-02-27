namespace MigrationUtils.Dal.Models
{
    public class ProjectSnapInterconnectionSpendStripYear:Audit
    {
        public int ProjectSnapInterconnectionSpendStripId { get; set; }

        public int Year { get; set; }

        public int? SourceId { get; set; }

        public string InterconnectionSpendTypeId { get; set; }

        public decimal? Amount { get; set; }
    }
}