using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntity
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransmissionEntity()
        {
            GirStudyWindows = new HashSet<GirStudyWindow>();
            Interconnections = new HashSet<Interconnection>();
            Interconnections1 = new HashSet<Interconnection>();
            NewStartProjects = new HashSet<NewStartProject>();
            ProjectRegionalTransmissionOwners = new HashSet<ProjectRegionalTransmissionOwner>();
            Projects = new HashSet<Project>();
            RateOfRefundabilityValues = new HashSet<RateOfRefundabilityValue>();
            SubEventNames = new HashSet<SubEventName>();
            TransmissionEntityEventTypes = new HashSet<TransmissionEntityEventType>();
            TransmissionEntityTemplates = new HashSet<TransmissionEntityTemplate>();
            TransmissionEntityGroups = new HashSet<TransmissionEntityGroup>();
            UpgradeCostTransmissionEntities = new HashSet<UpgradeCostTransmissionEntity>();
        }

        public int TransmissionEntityId { get; set; }

        [StringLength(50)] public string Name { get; set; }

        [StringLength(50)] public string ContactName { get; set; }

        [StringLength(50)] public string ContactPhone { get; set; }

        [StringLength(320)] public string ContactEmail { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        [StringLength(50)] public string IaSuspensionRights { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirStudyWindow> GirStudyWindows { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconnection> Interconnections { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconnection> Interconnections1 { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProject> NewStartProjects { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectRegionalTransmissionOwner> ProjectRegionalTransmissionOwners { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RateOfRefundabilityValue> RateOfRefundabilityValues { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventName> SubEventNames { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransmissionEntityEventType> TransmissionEntityEventTypes { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransmissionEntityTemplate> TransmissionEntityTemplates { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransmissionEntityGroup> TransmissionEntityGroups { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UpgradeCostTransmissionEntity> UpgradeCostTransmissionEntities { get; set; }
    }
}