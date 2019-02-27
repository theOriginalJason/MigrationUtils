using System;

namespace MigrationUtils.Dal.Models
{
    public class RefundSchedule : Audit
    {
        public int RefundScheduleId { get; set; }
        public int SubEventId { get; set; }
        public DateTimeOffset RefundDate { get; set; }
        public decimal RefundAmount { get; set; }
        public DateTimeOffset Type { get; set; }
        public bool IsDeleted { get; set; }
    }
}