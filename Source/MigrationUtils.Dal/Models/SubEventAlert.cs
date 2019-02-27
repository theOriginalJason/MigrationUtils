using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class SubEventAlert
    {
        public int SubEventAlertId { get; set; }

        [StringLength(50)] public string Type { get; set; }

        [StringLength(50)] public string Priority { get; set; }

        [StringLength(320)] public string Email { get; set; }

        [StringLength(50)] public string PhoneNumber { get; set; }

        public int SubEventId { get; set; }

        public virtual SubEventAlertType SubEventAlertType { get; set; }

        public virtual SubEvent SubEvent { get; set; }
    }
}