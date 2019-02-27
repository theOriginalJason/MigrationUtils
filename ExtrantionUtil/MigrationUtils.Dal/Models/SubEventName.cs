using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class SubEventName
    {
        public int SubEventNameId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public int SubEventTypeId { get; set; }

        public int TransmissionEntityId { get; set; }

        public virtual SubEventType SubEventType { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }
    }
}