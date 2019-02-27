using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class RateOfRefundabilityValue
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransmissionEntityId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubEventTypeId { get; set; }

        public decimal RateOfRefundability { get; set; }

        public virtual SubEventType SubEventType { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }
    }
}