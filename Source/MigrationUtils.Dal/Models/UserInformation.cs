using System;

namespace MigrationUtils.Dal.Models
{
    public class UserInformation
    {
        public string Username { get; set; }
        public DateTimeOffset LastActivityDate { get; set; }
    }
}