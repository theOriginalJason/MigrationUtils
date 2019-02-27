namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntityTemplate : Audit
    {
        public int TransmissionEntityTemplateId { get; set; }

        public string TemplateString { get; set; }

        public int TransmissionEntityId { get; set; }

        public bool IsDeleted { get; set; }
    }
}