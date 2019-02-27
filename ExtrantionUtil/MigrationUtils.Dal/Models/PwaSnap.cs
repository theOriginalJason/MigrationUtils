using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class PwaSnap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ProjectName { get; set; }

        [Key] [Column(Order = 2)] public Guid ProjectUID { get; set; }

        [StringLength(255)] public string TaskName { get; set; }

        public DateTimeOffset? Date { get; set; }

        public decimal? Forecast { get; set; }

        public decimal? Actuals { get; set; }

        public decimal? ProjectITD { get; set; }

        public decimal? ProjectYTD { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string CreatedBy { get; set; }

        [Key] [Column(Order = 4)] public DateTimeOffset CreatedDate { get; set; }

        public virtual Snap Snap { get; set; }
    }
}