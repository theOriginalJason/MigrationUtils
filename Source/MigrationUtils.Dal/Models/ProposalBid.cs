using System;

namespace MigrationUtils.Dal.Models
{
    public class ProposalBid : Audit
    {
        public int ProposalBidId { get; set; }

        public string Type { get; set; }

        public DateTimeOffset BidDate { get; set; }

        public bool IsBid { get; set; }

        public int ProposalId { get; set; }

        public bool IsDeleted { get; set; }
    }
}