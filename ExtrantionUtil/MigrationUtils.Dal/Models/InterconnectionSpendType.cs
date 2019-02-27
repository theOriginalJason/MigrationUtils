using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class InterconnectionSpendType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InterconnectionSpendType()
        {
            NewStartProjectInterconnectionSpendStripYears = new HashSet<NewStartProjectInterconnectionSpendStripYear>();
            ProjectSnapInterconnectionSpendStripYears = new HashSet<ProjectSnapInterconnectionSpendStripYear>();
        }

        [StringLength(50)] public string InterconnectionSpendTypeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectInterconnectionSpendStripYear>
            NewStartProjectInterconnectionSpendStripYears { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnapInterconnectionSpendStripYear> ProjectSnapInterconnectionSpendStripYears
        {
            get;
            set;
        }
    }
}