using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindowEventTemplate
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GirStudyWindowEventTemplate()
        {
            Events = new HashSet<Event>();
            GirStudyWindowSubEventTemplates = new HashSet<GirStudyWindowSubEventTemplate>();
        }

        public int GirStudyWindowEventTemplateId { get; set; }

        [Required] [StringLength(50)] public string Designation { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public int GirStudyWindowId { get; set; }

        public int TransmissionEntityEventTypeId { get; set; }

        [Required] [StringLength(50)] public string Description { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Events { get; set; }

        public virtual EventTypeDesignation EventTypeDesignation { get; set; }

        public virtual GirStudyWindow GirStudyWindow { get; set; }

        public virtual TransmissionEntityEventType TransmissionEntityEventType { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirStudyWindowSubEventTemplate> GirStudyWindowSubEventTemplates { get; set; }
    }
}