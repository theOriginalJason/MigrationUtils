using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProjectSnapInterconnectionSpendStrip
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectSnapInterconnectionSpendStrip()
        {
            ProjectSnapInterconnectionSpendStripYears = new HashSet<ProjectSnapInterconnectionSpendStripYear>();
        }

        public int ProjectSnapInterconnectionSpendStripId { get; set; }

        public int PortfolioPlanId { get; set; }

        public int ProjectId { get; set; }

        public int SnapId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public virtual PortfolioPlanProjectSnap PortfolioPlanProjectSnap { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnapInterconnectionSpendStripYear> ProjectSnapInterconnectionSpendStripYears
        {
            get;
            set;
        }
    }
}