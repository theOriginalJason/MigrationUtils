using System;

namespace MigrationUtils.Dal.Models
{
    public class InterconnectionScenario : Audit
    {

        public int InterconnectionScenarioId { get; set; }

        public string Name { get; set; }

        public DateTimeOffset Cod { get; set; }

        public int? OfftakerId { get; set; }

        public int InterconnectionId { get; set; }

        public string PoiDescription { get; set; }

        public string State { get; set; }

        public string IaIrOwner { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public decimal IaMw { get; set; }

        public decimal IaMwCommitted { get; set; }

        public string AgreementNumber { get; set; }

        public string AgreementDocument { get; set; }

        public string ResourceDesignationType { get; set; }

        public string ResourceType { get; set; }

        string GenNumber { get; set; }

        public int TransmissionEntityId { get; set; }

        public int TransmissionOwnerId { get; set; }

        public int ProjectId { get; set; }

        public decimal? Voltage { get; set; }

        public string PoiCounty { get; set; }

        public string Status { get; set; }

        public int? TransmissionEntityGroupId { get; set; }

        public int? ProjectLlcId { get; set; }

        public bool IsDeleted { get; set; }

        public string Description { get; set; }

        public bool IsArchived { get; set; }

        public decimal Mw { get; set; }
    }
}