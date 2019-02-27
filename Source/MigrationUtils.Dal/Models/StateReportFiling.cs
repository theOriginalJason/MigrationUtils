using System;

namespace MigrationUtils.Dal.Models
{
    public class StateReportFiling : Audit
    {
        public int StateReportFilingId { get; set; }

        public int StateReportTemplateId { get; set; }

        public int ProjectLlcId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset FilingDate { get; set; }

        public DateTimeOffset DueDate { get; set; }
    }
}