using System;

namespace MigrationUtils.Dal.Models
{
    public class Project : Audit
    {
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTimeOffset? ActualCod { get; set; }

        public DateTimeOffset? EarliestCod { get; set; }

        public string Status { get; set; }

        public string PriorityStatus { get; set; }

        public bool IsDeleted { get; set; }

        public string County { get; set; }

        public string State { get; set; }

        public string Region { get; set; }

        public decimal? Size { get; set; }

        public decimal? SiteSecured { get; set; }

        public decimal? RowSecured { get; set; }

        public string BusinessDevelopmentStatus { get; set; }

        public int? RegionalTransmissionOwnerId { get; set; }

        public DateTimeOffset? PlannedCod { get; set; }

        public int? ProjectLlcId { get; set; }

        public DateTimeOffset? BudgetedCOD { get; set; }

        public bool IsBiddable { get; set; }
    }
}