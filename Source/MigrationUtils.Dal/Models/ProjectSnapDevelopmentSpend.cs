using System;

namespace MigrationUtils.Dal.Models
{
    public class ProjectSnapDevelopmentSpend:Audit
    {
        public int PortfolioPlanId { get; set; }

        public int Year { get; set; }

        public int ProjectId { get; set; }

        public int SnapId { get; set; }

        public Guid? PwaSourceId { get; set; }

        public decimal? Amount { get; set; }

        public string DevelopmentSpendTypeId { get; set; }

        public int? PhaseSourceId { get; set; }
    }
}