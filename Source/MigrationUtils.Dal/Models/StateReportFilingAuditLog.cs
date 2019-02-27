using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class StateReportFilingAuditLog
    {
        public int StateReportFilingAuditLogId { get; set; }

        public int StateReportFilingId { get; set; }

        public DateTimeOffset AuditDate { get; set; }

        [Required] [StringLength(200)] public string EditedBy { get; set; }

        [Required] [StringLength(2000)] public string AuditMessage { get; set; }

        [Required] [StringLength(50)] public string AuditType { get; set; }

        public int ProjectLlcId { get; set; }
    }
}