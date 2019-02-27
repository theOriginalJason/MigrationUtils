using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class ExpenseReport
    {
        public int ExpenseReportId { get; set; }

        public int InterconnectionId { get; set; }

        public DateTimeOffset StatementDate { get; set; }

        [Required] [StringLength(50)] public string TPDepositNumber { get; set; }

        [Column(TypeName = "money")] public decimal DepositAmount { get; set; }

        [Column(TypeName = "money")] public decimal DepositSpent { get; set; }

        [Column(TypeName = "money")] public decimal DepositBalance { get; set; }

        [Required] [StringLength(50)] public string EventTypeDesignation { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public virtual EventTypeDesignation EventTypeDesignation1 { get; set; }

        public virtual Interconnection Interconnection { get; set; }
    }
}