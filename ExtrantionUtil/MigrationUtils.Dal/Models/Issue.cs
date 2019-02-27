using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class Issue
    {
        public int IssueId { get; set; }

        public int ProjectId { get; set; }

        [Required] [StringLength(50)] public string IssuePriorityTypeId { get; set; }

        [Required] [StringLength(50)] public string IssueStatusTypeId { get; set; }

        public DateTimeOffset DueDate { get; set; }

        [StringLength(100)] public string EntityResponsible { get; set; }

        public bool IsFinancial { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(2000)] public string Description { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public Guid? ResponsibleProjectTeamMemberId { get; set; }

        public bool IsDeleted { get; set; }

        public virtual IssuePriorityType IssuePriorityType { get; set; }

        public virtual IssueStatusType IssueStatusType { get; set; }

        public virtual Project Project { get; set; }
    }
}