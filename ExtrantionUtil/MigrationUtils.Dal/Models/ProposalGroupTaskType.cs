using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProposalGroupTaskType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProposalGroupTaskType()
        {
            ProposalGroupTasks = new HashSet<ProposalGroupTask>();
        }

        [StringLength(50)] public string ProposalGroupTaskTypeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProposalGroupTask> ProposalGroupTasks { get; set; }
    }
}