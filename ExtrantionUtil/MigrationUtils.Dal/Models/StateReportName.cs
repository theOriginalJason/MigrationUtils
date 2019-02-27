using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class StateReportName
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StateReportName()
        {
            StateReportTemplates = new HashSet<StateReportTemplate>();
        }

        [StringLength(50)] public string StateReportNameId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateReportTemplate> StateReportTemplates { get; set; }
    }
}