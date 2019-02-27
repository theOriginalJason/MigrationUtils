using System;

namespace MigrationUtils.Dal.Models
{
    public class ProposalGroup : Audit
    {
        public int ProposalGroupId { get; set; }

        public int CustomerId { get; set; }

        public string ProposalGroupStatusId { get; set; }

        public bool IsSolicited { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public bool BuildTransfer { get; set; }

        public bool IsApa { get; set; }

        public bool IsPpa { get; set; }

        public string Name { get; set; }

        public DateTimeOffset? ReleaseDate { get; set; }

        public string ProposalGroupTypeId { get; set; }

        public Guid? ProposalLeadId { get; set; }

        public Guid? OriginationLeadId { get; set; }

        public Guid? TransactionLeadId { get; set; }

        public string BrokerId { get; set; }
    }
}