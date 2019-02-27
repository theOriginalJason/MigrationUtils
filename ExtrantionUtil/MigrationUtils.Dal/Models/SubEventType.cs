using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class SubEventType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubEventType()
        {
            GirStudyWindowSubEventTemplates = new HashSet<GirStudyWindowSubEventTemplate>();
            RateOfRefundabilityValues = new HashSet<RateOfRefundabilityValue>();
            SubEventNames = new HashSet<SubEventName>();
            SubEvents = new HashSet<SubEvent>();
            SubEventTemplates = new HashSet<SubEventTemplate>();
        }

        public int SubEventTypeId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public bool IsMonetary { get; set; }

        [Required] [StringLength(50)] public string EventTypeDesignation { get; set; }

        [Required] [StringLength(200)] public string Description { get; set; }

        [Required] [StringLength(50)] public string MonetaryType { get; set; }

        public bool IsAmountNegative { get; set; }

        public bool ProjectIssueDisplay { get; set; }

        public virtual EventTypeDesignation EventTypeDesignation1 { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirStudyWindowSubEventTemplate> GirStudyWindowSubEventTemplates { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RateOfRefundabilityValue> RateOfRefundabilityValues { get; set; }

        public virtual SubEventMonetaryType SubEventMonetaryType { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventName> SubEventNames { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEvent> SubEvents { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventTemplate> SubEventTemplates { get; set; }
    }
}