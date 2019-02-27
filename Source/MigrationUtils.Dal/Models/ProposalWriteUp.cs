using System;

namespace MigrationUtils.Dal.Models
{
    public class ProposalWriteUp : Audit
    {
        public int ProposalWriteUpId { get; set; }

        public int ProposalId { get; set; }

        public string Type { get; set; }

        public bool IsDeleted { get; set; }

        public DateTimeOffset? CompletedDate { get; set; }
    }
}