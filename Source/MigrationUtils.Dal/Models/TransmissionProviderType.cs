using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class TransmissionProviderType
    {
        [StringLength(50)] public string TransmissionProviderTypeId { get; set; }
    }
}