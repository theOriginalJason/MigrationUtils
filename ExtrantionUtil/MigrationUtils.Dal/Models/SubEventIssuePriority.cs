using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class SubEventIssuePriority
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubEventId { get; set; }

        [StringLength(50)] public string IssuePriorityTypeId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(50)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(50)] public string UpdatedBy { get; set; }

        public virtual IssuePriorityType IssuePriorityType { get; set; }

        public virtual SubEvent SubEvent { get; set; }
    }
}