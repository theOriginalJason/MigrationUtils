using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProposalGroup
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProposalGroup()
        {
            ProposalGroupTasks = new HashSet<ProposalGroupTask>();
            Proposals = new HashSet<Proposal>();
        }

        public int ProposalGroupId { get; set; }

        public int CustomerId { get; set; }

        [Required] [StringLength(50)] public string ProposalGroupStatusId { get; set; }

        public bool IsSolicited { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public bool BuildTransfer { get; set; }

        public bool IsApa { get; set; }

        public bool IsPpa { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        [StringLength(500)] public string Name { get; set; }

        public DateTimeOffset? ReleaseDate { get; set; }

        [Required] [StringLength(50)] public string ProposalGroupTypeId { get; set; }

        public Guid? ProposalLeadId { get; set; }

        public Guid? OriginationLeadId { get; set; }

        public Guid? TransactionLeadId { get; set; }

        [StringLength(200)] public string BrokerId { get; set; }

        public virtual Broker Broker { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ProposalGroupStatus ProposalGroupStatus { get; set; }

        public virtual ProposalGroupType ProposalGroupType { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProposalGroupTask> ProposalGroupTasks { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proposal> Proposals { get; set; }
    }
}