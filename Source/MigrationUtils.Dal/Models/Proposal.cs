using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class Proposal
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proposal()
        {
            ProposalBids = new HashSet<ProposalBid>();
            ProposalWriteUps = new HashSet<ProposalWriteUp>();
        }

        public int ProposalId { get; set; }

        public int ProjectId { get; set; }

        [Required] [StringLength(50)] public string Status { get; set; }

        public DateTimeOffset WriteUpDueDate { get; set; }

        public int ProposalGroupId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public int? InterConnectionId { get; set; }

        public virtual Interconnection Interconnection { get; set; }

        public virtual Project Project { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProposalBid> ProposalBids { get; set; }

        public virtual ProposalGroup ProposalGroup { get; set; }

        public virtual ProposalStatus ProposalStatus { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProposalWriteUp> ProposalWriteUps { get; set; }
    }
}