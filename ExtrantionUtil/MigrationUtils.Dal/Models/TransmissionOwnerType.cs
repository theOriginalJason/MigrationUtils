using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class TransmissionOwnerType
    {
        [StringLength(50)] public string TransmissionOwnerTypeId { get; set; }
    }
}