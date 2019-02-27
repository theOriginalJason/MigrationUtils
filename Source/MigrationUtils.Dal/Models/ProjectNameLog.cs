using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class ProjectNameLog
    {
        public int ProjectNameLogId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public int ProjectId { get; set; }

        public DateTimeOffset ChangeDate { get; set; }

        [Required] [StringLength(200)] public string ChangedBy { get; set; }

        public virtual Project Project { get; set; }
    }
}