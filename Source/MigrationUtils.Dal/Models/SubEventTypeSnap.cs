using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class SubEventTypeSnap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubEventTypeId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public bool IsMonetary { get; set; }

        [Required] [StringLength(50)] public string EventTypeDesignation { get; set; }

        [Required] [StringLength(200)] public string Description { get; set; }

        [Required] [StringLength(50)] public string MonetaryType { get; set; }

        public bool IsAmountNegative { get; set; }

        public bool ProjectIssueDisplay { get; set; }

        public virtual Snap Snap { get; set; }
    }
}