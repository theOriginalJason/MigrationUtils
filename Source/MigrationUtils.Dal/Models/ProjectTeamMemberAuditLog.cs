using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class ProjectTeamMemberAuditLog
    {
        public int ProjectTeamMemberAuditLogId { get; set; }

        public int ProjectTeamMemberId { get; set; }

        public DateTimeOffset AuditDate { get; set; }

        [Required] [StringLength(200)] public string EditedBy { get; set; }

        [Required] [StringLength(2000)] public string AuditMessage { get; set; }

        [Required] [StringLength(50)] public string AuditType { get; set; }

        public Guid? ObjectGuid { get; set; }

        public int? ProjectId { get; set; }

        [StringLength(50)] public string Role { get; set; }
    }
}