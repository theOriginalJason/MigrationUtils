using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanCopy
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OldPortfolioPlanId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewPortfolioPlanId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [Required] [StringLength(50)] public string CopyStatusId { get; set; }

        [StringLength(2000)] public string ErrorMessage { get; set; }

        public virtual PortfolioPlanCopyStatus PortfolioPlanCopyStatus { get; set; }

        public virtual PortfolioPlan PortfolioPlan { get; set; }
    }
}