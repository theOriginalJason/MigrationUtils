using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectDevelopmentSpend
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PortfolioPlanId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewStartProjectId { get; set; }

        public Guid? PwaSourceId { get; set; }

        public decimal? Amount { get; set; }

        [StringLength(50)] public string DevelopmentSpendTypeId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public int? PhaseSourceId { get; set; }

        public virtual DevelopmentSpendType DevelopmentSpendType { get; set; }

        public virtual NewStartProject NewStartProject { get; set; }

        public virtual Phase Phase { get; set; }

        public virtual PortfolioPlanScheduleEntry PortfolioPlanScheduleEntry { get; set; }
    }
}