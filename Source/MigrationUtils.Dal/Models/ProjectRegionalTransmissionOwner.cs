using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class ProjectRegionalTransmissionOwner
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionalTransmissionOwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(50)] public string CreatedBy { get; set; }

        public virtual Project Project { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }
    }
}