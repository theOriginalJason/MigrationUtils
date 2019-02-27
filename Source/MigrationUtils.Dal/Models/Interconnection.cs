using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class Interconnection
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Interconnection()
        {
            Events = new HashSet<Event>();
            ExpenseReports = new HashSet<ExpenseReport>();
            Proposals = new HashSet<Proposal>();
        }

        public int InterconnectionId { get; set; }

        public string PoiDescription { get; set; }

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

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsTemplate { get; set; }

        public int? ProjectLlcId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseReport> ExpenseReports { get; set; }

        public virtual InterconnectionStatus InterconnectionStatus { get; set; }

        public virtual ProjectLlc ProjectLlc { get; set; }

        public virtual Project Project { get; set; }

        public virtual ResourceDesignationType ResourceDesignationType1 { get; set; }

        public virtual ResourceType ResourceType1 { get; set; }

        public virtual State State1 { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }

        public virtual TransmissionEntity TransmissionEntity1 { get; set; }

        public virtual TransmissionEntityGroup TransmissionEntityGroup { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proposal> Proposals { get; set; }
    }
}