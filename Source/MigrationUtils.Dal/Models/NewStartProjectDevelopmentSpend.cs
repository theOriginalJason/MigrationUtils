using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectDevelopmentSpend : Audit
    {
        public int PortfolioPlanId { get; set; }

        public int Year { get; set; }

        public int NewStartProjectId { get; set; }

        public Guid? PwaSourceId { get; set; }

        public decimal? Amount { get; set; }

        public string DevelopmentSpendTypeId { get; set; }

        public int? PhaseSourceId { get; set; }
    }
}