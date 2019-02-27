using System;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProject
    {
        public int NewStartProjectId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string State { get; set; }

        public string Region { get; set; }

        public decimal? Size { get; set; }

        public int RegionalTransmissionOwnerId { get; set; }

        public DateTimeOffset? BudgetedCOD { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedOn { get; set; }
    }
}