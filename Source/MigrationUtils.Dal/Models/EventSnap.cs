using System;

namespace MigrationUtils.Dal.Models
{
    public class EventSnap : Audit
    {
        public int SnapId { get; set; }
        public int EventId { get; set; }
        public decimal? Price { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public DateTimeOffset? DeadlineDate { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string ResourceDesignationType { get; set; }
        public DateTimeOffset? CommercialOperatingDate { get; set; }
        public string Manufacturer { get; set; }
        public string Status { get; set; }
        public int? InterconnectionId { get; set; }
        public decimal NonRefundableFunds { get; set; }
        public decimal? StudyMegawatts { get; set; }
        public DateTimeOffset? CompletedDate { get; set; }
        public int GirStudyWindowId { get; set; }
        public int? TransmissionEntityEventTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsTemplate { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Identifier { get; set; 
    }
}