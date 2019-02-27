namespace MigrationUtils.Dal.Models
{
    public class UpgradeCost : Audit
    {
        public int UpgradeCostId { get; set; }

        public string Type { get; set; }

        public decimal Cost { get; set; }

        public int EventId { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public decimal? LineLength { get; set; }

        public bool IsCurrent { get; set; }

        public string UpgradeCostResourceDesignationType { get; set; }

        public decimal TotalUpgradeCost { get; set; }

        public bool IsEligibleForCredits { get; set; }
    }
}