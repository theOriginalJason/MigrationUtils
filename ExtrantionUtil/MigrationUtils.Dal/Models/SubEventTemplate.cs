using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class SubEventTemplate
    {
        public int SubEventTemplateId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public int SubEventTypeId { get; set; }

        public int TransmissionEntityEventTypeId { get; set; }

        public virtual TransmissionEntityEventType TransmissionEntityEventType { get; set; }

        public virtual SubEventType SubEventType { get; set; }
    }
}