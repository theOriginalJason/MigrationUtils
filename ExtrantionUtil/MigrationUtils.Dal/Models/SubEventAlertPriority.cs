using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class SubEventAlertPriority
    {
        [StringLength(50)] public string SubEventAlertPriorityId { get; set; }
    }
}