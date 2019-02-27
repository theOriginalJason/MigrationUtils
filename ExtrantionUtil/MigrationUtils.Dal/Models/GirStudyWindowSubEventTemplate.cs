using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindowSubEventTemplate
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GirStudyWindowSubEventTemplate()
        {
            SubEvents = new HashSet<SubEvent>();
        }

        public int GirStudyWindowSubEventTemplateId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public int SubEventTypeId { get; set; }

        public int GirStudyWindowEventTemplateId { get; set; }

        public DateTimeOffset TpInitialDueDate { get; set; }

        public DateTimeOffset TpProjectedDate { get; set; }

        public DateTimeOffset TweExpectedDate { get; set; }

        public DateTimeOffset? ActualDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public DateTimeOffset? AtRiskDate { get; set; }

        public virtual GirStudyWindowEventTemplate GirStudyWindowEventTemplate { get; set; }

        public virtual SubEventType SubEventType { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEvent> SubEvents { get; set; }
    }
}