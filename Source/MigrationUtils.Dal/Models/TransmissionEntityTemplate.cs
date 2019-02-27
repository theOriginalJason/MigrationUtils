using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntityTemplate
    {
        public int TransmissionEntityTemplateId { get; set; }

        public string TemplateString { get; set; }

        public int TransmissionEntityId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }
    }
}