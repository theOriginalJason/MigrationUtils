using System;

namespace MigrationUtils.Dal.Models
{
    public class ProposalGroupTask : Audit
    {
        public int ProposalGroupTaskId { get; set; }

        public string ProposalGroupTaskTypeId { get; set; }

        public int ProposalGroupId { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public DateTimeOffset? SubmissionDate { get; set; }
    }
}