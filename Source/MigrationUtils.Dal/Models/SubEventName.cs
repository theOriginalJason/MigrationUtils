namespace MigrationUtils.Dal.Models
{
    public class SubEventName
    {
        public int SubEventNameId { get; set; }

        public string Name { get; set; }

        public int SubEventTypeId { get; set; }

        public int TransmissionEntityId { get; set; }
    }
}