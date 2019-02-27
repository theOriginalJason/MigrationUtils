using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectInterconnectionSpendStrip
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewStartProjectInterconnectionSpendStrip()
        {
            NewStartProjectInterconnectionSpendStripYears = new HashSet<NewStartProjectInterconnectionSpendStripYear>();
        }

        public int NewStartProjectInterconnectionSpendStripId { get; set; }

        public int NewStartProjectId { get; set; }

        public int PortfolioPlanId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public virtual PortfolioPlanNewStartProject PortfolioPlanNewStartProject { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectInterconnectionSpendStripYear>
            NewStartProjectInterconnectionSpendStripYears { get; set; }
    }
}