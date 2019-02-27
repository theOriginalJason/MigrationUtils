namespace MigrationUtils.Dal.Models
{
    public class ProjectSnapInterconnectionSpendStrip :Audit
    {
        public int ProjectSnapInterconnectionSpendStripId { get; set; }

        public int PortfolioPlanId { get; set; }

        public int ProjectId { get; set; }

        public int SnapId { get; set; }
    }
}