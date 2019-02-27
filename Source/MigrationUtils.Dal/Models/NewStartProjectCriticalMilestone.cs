using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectCriticalMilestone
    {
        public int NewStartProjectCriticalMilestoneId { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        public DateTimeOffset? EstimatedDate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public int NewStartProjectId { get; set; }

        public virtual CriticalMilestoneName CriticalMilestoneName { get; set; }

        public virtual NewStartProject NewStartProject { get; set; }
    }
}