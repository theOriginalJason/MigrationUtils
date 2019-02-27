using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntityEventType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransmissionEntityEventType()
        {
            Events = new HashSet<Event>();
            GirStudyWindowEventTemplates = new HashSet<GirStudyWindowEventTemplate>();
            SubEventTemplates = new HashSet<SubEventTemplate>();
        }

        public int TransmissionEntityEventTypeId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public int TransmissionEntityId { get; set; }

        [Required] [StringLength(50)] public string Designation { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }

        public virtual EventTypeDesignation EventTypeDesignation { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirStudyWindowEventTemplate> GirStudyWindowEventTemplates { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventTemplate> SubEventTemplates { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }
    }
}