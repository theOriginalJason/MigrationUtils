using System;

namespace MigrationUtils.Dal.Models
{
    public class LoginLog
    {
        public int LoginLogId { get; set; }

        public string Username { get; set; }

        public DateTimeOffset LoginDate { get; set; }
    }
}