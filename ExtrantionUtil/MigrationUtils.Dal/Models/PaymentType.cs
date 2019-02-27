using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class PaymentType
    {
        [StringLength(50)] public string PaymentTypeId { get; set; }
    }
}