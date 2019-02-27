using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlan
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PortfolioPlan()
        {
            PortfolioPlanCopies = new HashSet<PortfolioPlanCopy>();
            PortfolioPlanNewStartProjects = new HashSet<PortfolioPlanNewStartProject>();
            PortfolioPlanProjectSnaps = new HashSet<PortfolioPlanProjectSnap>();
            PortfolioPlanScheduleEntries = new HashSet<PortfolioPlanScheduleEntry>();
        }

        public int PortfolioPlanId { get; set; }

        [Required] [StringLength(200)] public string Name { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public int SnapId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanCopy> PortfolioPlanCopies { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanNewStartProject> PortfolioPlanNewStartProjects { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanProjectSnap> PortfolioPlanProjectSnaps { get; set; }

        public virtual Snap Snap { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanScheduleEntry> PortfolioPlanScheduleEntries { get; set; }
    }
}