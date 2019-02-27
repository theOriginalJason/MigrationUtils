using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class PwaProjectSnap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Key] [Column(Order = 1)] public Guid ProjectUID { get; set; }

        [Required] [StringLength(255)] public string ProjectName { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public int? HorizonProjectId { get; set; }
    }
}