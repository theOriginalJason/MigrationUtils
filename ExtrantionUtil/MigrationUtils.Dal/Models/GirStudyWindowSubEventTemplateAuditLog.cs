using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindowSubEventTemplateAuditLog
    {
        public int GirStudyWindowSubEventTemplateAuditLogId { get; set; }

        public int GirStudyWindowSubEventTemplateId { get; set; }

        public DateTimeOffset AuditDate { get; set; }

        [Required] [StringLength(200)] public string EditedBy { get; set; }

        [Required] [StringLength(2000)] public string AuditMessage { get; set; }

        [Required] [StringLength(50)] public string AuditType { get; set; }
    }
}