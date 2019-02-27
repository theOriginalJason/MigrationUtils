using System;

namespace MigrationUtils.Dal.Models
{
    public class SubEventSnap :Audit
    {
        public int SnapId { get; set; }
        public int SubEventId { get; set; }
        public DateTimeOffset? DueDate { get; set; }
        public DateTimeOffset? ActualDate { get; set; }
        public DateTimeOffset? LcReleaseDate { get; set; }
        public DateTimeOffset? AtRiskDate { get; set; }
        public decimal? Amount { get; set; }
        public int EventId { get; set; }
        public string PaymentType { get; set; }
        public int SubEventTypeId { get; set; }
        public decimal? AmountExpensed { get; set; }
        public bool IsDeleted { get; set; }
        public DateTimeOffset? TbdDate { get; set; }
        public string Name { get; set; }
        public decimal? AmountRefundable { get; set; }
        public bool IsTemplate { get; set; }
        public bool IsMonetary { get; set; }
        public string EventTypeDesignation { get; set; }
        public string MonetaryType { get; set; }
        public string Status { get; set; }
        public DateTimeOffset? AtRiskReleaseDate { get; set; }
    }
}