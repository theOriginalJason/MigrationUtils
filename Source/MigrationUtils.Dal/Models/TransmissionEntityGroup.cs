namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntityGroup: Audit
    {
        public int TransmissionEntityGroupId { get; set; }

        public string Name { get; set; }

        public int TransmissionEntityId { get; set; }

        public bool IsDeleted { get; set; }
    }
}