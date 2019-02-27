namespace MigrationUtils.Dal.Models
{
    public class UpgradeCostTransmissionEntity : Audit
    {
        public int UpgradeCostId { get; set; }
        public int TransmissionEntityId { get; set; }
    }
}