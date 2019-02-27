namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntityEventTypeSnap:Audit
    {
        public int SnapId { get; set; }

        public int TransmissionEntityEventTypeId { get; set; }

        public string Name { get; set; }

        public int TransmissionEntityId { get; set; }

        public string Designation { get; set; }

        public bool IsDeleted { get; set; }
    }
}