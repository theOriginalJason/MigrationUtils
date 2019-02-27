namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectInterconnectionSpendStrip : Audit
    {
        public int NewStartProjectInterconnectionSpendStripId { get; set; }

        public int NewStartProjectId { get; set; }

        public int PortfolioPlanId { get; set; }
    }
}