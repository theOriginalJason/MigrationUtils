using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class UpgradeCostResourceDesignationType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UpgradeCostResourceDesignationType()
        {
            UpgradeCosts = new HashSet<UpgradeCost>();
        }

        [StringLength(50)] public string UpgradeCostResourceDesignationTypeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UpgradeCost> UpgradeCosts { get; set; }
    }
}