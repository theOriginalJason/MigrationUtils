using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class SubEventMonetaryType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubEventMonetaryType()
        {
            SubEventTypes = new HashSet<SubEventType>();
        }

        [StringLength(50)] public string SubEventMonetaryTypeId { get; set; }

        public bool IsMonetary { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventType> SubEventTypes { get; set; }
    }
}