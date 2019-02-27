using System;

namespace MigrationUtils.Dal.Models
{
    public class ProjectLlcFilingState:Audit
    {
        public int ProjectLlcId { get; set; }

        public string StateId { get; set; }

        public string ProjectLlcFilingStateTypeId { get; set; }

        public DateTimeOffset FilingDate { get; set; }

        public string FilingStateId { get; set; }

        public string Status { get; set; }
    }
}