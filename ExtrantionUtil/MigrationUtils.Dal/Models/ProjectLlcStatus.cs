using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    [Table("ProjectLlcStatuses")]
    public class ProjectLlcStatus
    {
        [StringLength(50)] public string ProjectLlcStatusId { get; set; }
    }
}