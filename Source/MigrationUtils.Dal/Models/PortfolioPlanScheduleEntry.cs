namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanScheduleEntry : Audit
    {
        public int PortfolioPlanId { get; set; }

        public int Year { get; set; }

        public decimal CodMw { get; set; }
    }
}