using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    [Table("ProposalStatuses")]
    public class ProposalStatus
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProposalStatus()
        {
            Proposals = new HashSet<Proposal>();
        }

        [StringLength(50)] public string ProposalStatusId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proposal> Proposals { get; set; }
    }
}