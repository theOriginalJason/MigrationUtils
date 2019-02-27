using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class ProposalGroupTask
    {
        public int ProposalGroupTaskId { get; set; }

        [Required] [StringLength(50)] public string ProposalGroupTaskTypeId { get; set; }

        public int ProposalGroupId { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public DateTimeOffset? SubmissionDate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public virtual ProposalGroup ProposalGroup { get; set; }

        public virtual ProposalGroupTaskType ProposalGroupTaskType { get; set; }
    }
}