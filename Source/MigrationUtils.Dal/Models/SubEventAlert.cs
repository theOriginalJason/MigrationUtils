namespace MigrationUtils.Dal.Models
{
    public class SubEventAlert
    {
        public int SubEventAlertId { get; set; }

        public string Type { get; set; }

        public string Priority { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int SubEventId { get; set; }
    }
}