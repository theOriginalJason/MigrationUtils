using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProposalWriteUpType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProposalWriteUpType()
        {
            ProjectWriteUps = new HashSet<ProjectWriteUp>();
            ProposalWriteUps = new HashSet<ProposalWriteUp>();
        }

        [StringLength(50)] public string ProposalWriteUpTypeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectWriteUp> ProjectWriteUps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProposalWriteUp> ProposalWriteUps { get; set; }
    }
}