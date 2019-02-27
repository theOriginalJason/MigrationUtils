using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class StateReportInterval
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StateReportInterval()
        {
            StateReportTemplates = new HashSet<StateReportTemplate>();
        }

        [StringLength(50)] public string StateReportIntervalId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateReportTemplate> StateReportTemplates { get; set; }
    }
}