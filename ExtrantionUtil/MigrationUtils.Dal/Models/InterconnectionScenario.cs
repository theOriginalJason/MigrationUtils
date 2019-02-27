using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class InterconnectionScenario
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InterconnectionScenario()
        {
            EventScenarios = new HashSet<EventScenario>();
        }

        public int InterconnectionScenarioId { get; set; }

        [Required] [StringLength(500)] public string Name { get; set; }

        public DateTimeOffset Cod { get; set; }

        public int? OfftakerId { get; set; }

        public int InterconnectionId { get; set; }

        [StringLength(1000)] public string PoiDescription { get; set; }

        [Required] [StringLength(50)] public string State { get; set; }

        [StringLength(50)] public string IaIrOwner { get; set; }

        [StringLength(50)] public string Manufacturer { get; set; }

        [StringLength(50)] public string Model { get; set; }

        public decimal IaMw { get; set; }

        public decimal IaMwCommitted { get; set; }

        [StringLength(50)] public string AgreementNumber { get; set; }

        [StringLength(50)] public string AgreementDocument { get; set; }

        [StringLength(50)] public string ResourceDesignationType { get; set; }

        [Required] [StringLength(50)] public string ResourceType { get; set; }

        [StringLength(50)] public string GenNumber { get; set; }

        public int TransmissionEntityId { get; set; }

        public int TransmissionOwnerId { get; set; }

        public int ProjectId { get; set; }

        public decimal? Voltage { get; set; }

        [StringLength(50)] public string PoiCounty { get; set; }

        [StringLength(50)] public string Status { get; set; }

        public int? TransmissionEntityGroupId { get; set; }

        public int? ProjectLlcId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(20)] public string Description { get; set; }

        public bool IsArchived { get; set; }

        public decimal Mw { get; set; }

        public virtual Customer Customer { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventScenario> EventScenarios { get; set; }
    }
}