using System;

namespace MigrationUtils.Dal.Models
{
    public class CriticalMilestoneSnap: Audit
    {
        public int SnapId { get; set; }
        public int CriticalMilestoneId { get; set; }

        public DateTimeOffset? EstimatedDate { get; set; }

        public DateTimeOffset? ActualDate { get; set; }

        public int ProjectId { get; set; }

        public string Progression { get; set; }

        public bool IsDeleted { get; set; }

        public string Name { get; set; }
    }
}