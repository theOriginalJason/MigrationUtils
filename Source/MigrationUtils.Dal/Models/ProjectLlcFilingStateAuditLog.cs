using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class ProjectLlcFilingStateAuditLog
    {
        public int ProjectLlcFilingStateAuditLogId { get; set; }

        public int ProjectLlcId { get; set; }

        public DateTimeOffset AuditDate { get; set; }

        [Required] [StringLength(200)] public string EditedBy { get; set; }

        [Required] [StringLength(2000)] public string AuditMessage { get; set; }

        [Required] [StringLength(50)] public string AuditType { get; set; }

        [Required] [StringLength(50)] public string StateId { get; set; }

        [Required] [StringLength(50)] public string ProjectLlcFilingStateTypeId { get; set; }
    }
}