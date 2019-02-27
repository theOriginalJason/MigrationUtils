using System;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectCriticalMilestone :Audit
    {
        public int NewStartProjectCriticalMilestoneId { get; set; }

        public string Name { get; set; }

        public DateTimeOffset? EstimatedDate { get; set; }

        public int NewStartProjectId { get; set; }

        public virtual CriticalMilestoneName CriticalMilestoneName { get; set; }

        public virtual NewStartProject NewStartProject { get; set; }
    }
}