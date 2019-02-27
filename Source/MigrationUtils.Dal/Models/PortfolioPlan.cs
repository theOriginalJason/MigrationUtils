namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlan:Audit
    {
        public int PortfolioPlanId { get; set; }

        public string Name { get; set; }

        public int SnapId { get; set; }
    }
}