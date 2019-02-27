using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    [Table("UserInformation")]
    public class UserInformation
    {
        [Key] [StringLength(320)] public string Username { get; set; }

        public DateTimeOffset LastActivityDate { get; set; }
    }
}