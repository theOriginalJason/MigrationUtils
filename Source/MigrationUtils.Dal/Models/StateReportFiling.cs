using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class StateReportFiling
    {
        public int StateReportFilingId { get; set; }

        public int StateReportTemplateId { get; set; }

        public int ProjectLlcId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset FilingDate { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public virtual ProjectLlc ProjectLlc { get; set; }

        public virtual StateReportTemplate StateReportTemplate { get; set; }
    }
}