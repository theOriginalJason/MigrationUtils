using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class UpgradeCost
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UpgradeCost()
        {
            UpgradeCostTransmissionEntities = new HashSet<UpgradeCostTransmissionEntity>();
        }

        public int UpgradeCostId { get; set; }

        [StringLength(50)] public string Type { get; set; }

        [Column(TypeName = "money")] public decimal Cost { get; set; }

        public int EventId { get; set; }

        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [Column(TypeName = "numeric")] public decimal? LineLength { get; set; }

        public bool IsCurrent { get; set; }

        [StringLength(50)] public string UpgradeCostResourceDesignationType { get; set; }

        [Column(TypeName = "money")] public decimal TotalUpgradeCost { get; set; }

        public bool IsEligibleForCredits { get; set; }

        public virtual Event Event { get; set; }

        public virtual UpgradeCostResourceDesignationType UpgradeCostResourceDesignationType1 { get; set; }

        public virtual UpgradeCostType UpgradeCostType { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UpgradeCostTransmissionEntity> UpgradeCostTransmissionEntities { get; set; }
    }
}