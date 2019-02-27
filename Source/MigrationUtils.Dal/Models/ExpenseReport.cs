using System;

namespace MigrationUtils.Dal.Models
{
    public class ExpenseReport : Audit
    {
        public int ExpenseReportId { get; set; }

        public int InterconnectionId { get; set; }

        public DateTimeOffset StatementDate { get; set; }

        public string TPDepositNumber { get; set; }

        public decimal DepositAmount { get; set; }

        public decimal DepositSpent { get; set; }

        public decimal DepositBalance { get; set; }

        public string EventTypeDesignation { get; set; }

        public bool IsDeleted { get; set; }
    }
}