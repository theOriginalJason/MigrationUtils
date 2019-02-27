using System;

namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanNewStartProject : Audit
    {
        public int PortfolioPlanId { get; set; }

        public int NewStartProjectId { get; set; }

        public string FinalOutcome { get; set; }

        public DateTimeOffset? FinalOutcomeDate { get; set; }
    }
}