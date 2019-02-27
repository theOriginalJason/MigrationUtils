using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class EventType
    {
        [StringLength(50)] public string EventTypeId { get; set; }
    }
}