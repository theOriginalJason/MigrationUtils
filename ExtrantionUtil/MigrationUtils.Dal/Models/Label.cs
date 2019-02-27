using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class Label
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LabelTypeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string LabelName { get; set; }

        [Required] [StringLength(500)] public string LabelValue { get; set; }

        public virtual LabelType LabelType { get; set; }
    }
}