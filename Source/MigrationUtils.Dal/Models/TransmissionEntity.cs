namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntity : Audit
    {
        public int TransmissionEntityId { get; set; }

        public string Name { get; set; }

        public string ContactName { get; set; }

        public string ContactPhone { get; set; }

        public string ContactEmail { get; set; }

        public string Type { get; set; }

        public string IaSuspensionRights { get; set; }

        public bool IsDeleted { get; set; }
    }
}