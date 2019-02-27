using System;

namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanProjectSnap : Audit
    {
        public int PortfolioPlanId { get; set; }

        public int ProjectId { get; set; }

        public int SnapId { get; set; }

        public string FinalOutcome { get; set; }

        public DateTimeOffset? FinalOutcomeDate { get; set; }
    }
}