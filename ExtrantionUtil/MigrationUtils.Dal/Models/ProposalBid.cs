using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class ProposalBid
    {
        public int ProposalBidId { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        public DateTimeOffset BidDate { get; set; }

        public bool IsBid { get; set; }

        public int ProposalId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ProposalBidType ProposalBidType { get; set; }

        public virtual Proposal Proposal { get; set; }
    }
}