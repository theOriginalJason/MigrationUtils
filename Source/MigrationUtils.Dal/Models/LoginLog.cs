using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class LoginLog
    {
        public int LoginLogId { get; set; }

        [Required] [StringLength(50)] public string Username { get; set; }

        public DateTimeOffset LoginDate { get; set; }
    }
}