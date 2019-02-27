using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    [Table("PortfolioPlanCopyStatuses")]
    public class PortfolioPlanCopyStatus
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PortfolioPlanCopyStatus()
        {
            PortfolioPlanCopies = new HashSet<PortfolioPlanCopy>();
        }

        [StringLength(50)] public string PortfolioPlanCopyStatusId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanCopy> PortfolioPlanCopies { get; set; }
    }
}