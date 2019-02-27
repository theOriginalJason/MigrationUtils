using System;

namespace MigrationUtils.Dal.Models
{
    public class Proposal : Audit
    {
        public int ProposalId { get; set; }

        public int ProjectId { get; set; }

        public string Status { get; set; }

        public DateTimeOffset WriteUpDueDate { get; set; }

        public int ProposalGroupId { get; set; }

        public bool IsDeleted { get; set; }

        public int? InterConnectionId { get; set; }
    }
}