namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanProjectSnapCopyDifference : Audit
    {
        public int PortfolioPlanProjectSnapCopyDifferenceId { get; set; }

        public int? PortfolioPlanId { get; set; }

        public int? ProjectId { get; set; }

        public int? SnapId { get; set; }

        public bool? NeedsAction { get; set; }

        public string Description { get; set; }
    }
}