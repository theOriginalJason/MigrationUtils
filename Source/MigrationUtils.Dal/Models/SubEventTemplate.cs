namespace MigrationUtils.Dal.Models
{
    public class SubEventTemplate
    {
        public int SubEventTemplateId { get; set; }

        public string Name { get; set; }

        public int SubEventTypeId { get; set; }

        public int TransmissionEntityEventTypeId { get; set; }
    }
}