using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class EventTypeDesignation
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventTypeDesignation()
        {
            ExpenseReports = new HashSet<ExpenseReport>();
            GirStudyWindowEventTemplates = new HashSet<GirStudyWindowEventTemplate>();
            SubEventTypes = new HashSet<SubEventType>();
            TransmissionEntityEventTypes = new HashSet<TransmissionEntityEventType>();
        }

        [StringLength(50)] public string EventTypeDesignationId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExpenseReport> ExpenseReports { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirStudyWindowEventTemplate> GirStudyWindowEventTemplates { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventType> SubEventTypes { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransmissionEntityEventType> TransmissionEntityEventTypes { get; set; }
    }
}