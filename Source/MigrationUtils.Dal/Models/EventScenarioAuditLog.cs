using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class EventScenarioAuditLog
    {
        public int EventScenarioAuditLogId { get; set; }

        public int EventScenarioId { get; set; }

        [Column(TypeName = "datetime2")] public DateTime AuditDate { get; set; }

        [Required] [StringLength(200)] public string EditedBy { get; set; }

        [Required] [StringLength(2000)] public string AuditMessage { get; set; }

        [Required] [StringLength(50)] public string AuditType { get; set; }
    }
}