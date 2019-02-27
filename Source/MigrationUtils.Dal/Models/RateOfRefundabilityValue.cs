namespace MigrationUtils.Dal.Models
{
    public class RateOfRefundabilityValue
    {
        public int TransmissionEntityId { get; set; }
        public int SubEventTypeId { get; set; }

        public decimal RateOfRefundability { get; set; }
    }
}