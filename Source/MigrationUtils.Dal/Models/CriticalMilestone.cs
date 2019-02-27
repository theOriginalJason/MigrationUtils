using System;
namespace MigrationUtils.Dal.Models
{
    public class CriticalMilestone : Audit
    {
        public int CriticalMilestoneId { get; set; }

        public DateTimeOffset? EstimatedDate { get; set; }

        public DateTimeOffset? ActualDate { get; set; }

        public int ProjectId { get; set; }

        public string Progression { get; set; }

        public bool IsDeleted { get; set; }

        public string Name { get; set; }
    }
}