using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    [Table("ProposalGroupStatuses")]
    public class ProposalGroupStatus
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProposalGroupStatus()
        {
            ProposalGroups = new HashSet<ProposalGroup>();
        }

        [StringLength(50)] public string ProposalGroupStatusId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProposalGroup> ProposalGroups { get; set; }
    }
}