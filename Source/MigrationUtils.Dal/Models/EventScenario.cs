using System;
namespace MigrationUtils.Dal.Models
{
    public class EventScenario : Audit
    {
        public int EventScenarioId { get; set; }

        public int InterconnectionScenarioId { get; set; }

        public int? EventId { get; set; }

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

        public int? TransmissionEntityEventTypeId { get; set; }

        public string Designation { get; set; }

        public bool IsDeleted { get; set; }

      
    }
}