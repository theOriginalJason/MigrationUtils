using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class Issue :Audit
    {
        public int IssueId { get; set; }

        public int ProjectId { get; set; }

        public string IssuePriorityTypeId { get; set; }

        public string IssueStatusTypeId { get; set; }

        public DateTimeOffset DueDate { get; set; }

        public string EntityResponsible { get; set; }

        public bool IsFinancial { get; set; }

        public decimal? Amount { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public Guid? ResponsibleProjectTeamMemberId { get; set; }

        public bool IsDeleted { get; set; }
    }
}