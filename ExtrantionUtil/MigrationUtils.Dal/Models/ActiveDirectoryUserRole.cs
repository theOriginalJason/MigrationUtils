using System;

namespace MigrationUtils.Dal.Models
{
    public class ActiveDirectoryUserRole
    {
        public string Username { get; set; }

        public string GroupNames { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
    }
}