using System;

namespace MigrationUtils.Dal.Models
{
    public class ProjectTeamMember : Audit
    {
        public Guid ObjectGuid { get; set; }

        public int ProjectId { get; set; }

        public string Role { get; set; }

        public bool IsDeleted { get; set; }
    }
}