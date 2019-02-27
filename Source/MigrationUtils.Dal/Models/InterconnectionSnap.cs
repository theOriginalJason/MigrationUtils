using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class InterconnectionSnap :Audit
    {
        
        public int SnapId { get; set; }

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

        public string GenNumber { get; set; }

        public int TransmissionEntityId { get; set; }

        public int TransmissionOwnerId { get; set; }

        public int ProjectId { get; set; }

        public decimal? Voltage { get; set; }

        public string PoiCounty { get; set; }

        public string Status { get; set; }

        public int? TransmissionEntityGroupId { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsTemplate { get; set; }

        public int? ProjectLlcId { get; set; }

    }
}