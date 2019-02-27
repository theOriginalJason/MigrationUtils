namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectInterconnectionSpendStripYear : Audit
    {
        public int NewStartProjectInterconnectionSpendStripId { get; set; }

        public int Year { get; set; }

        public int? SourceId { get; set; }

        public string InterconnectionSpendTypeId { get; set; }

        public decimal? Amount { get; set; }
    }
}