using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class Manufacturer
    {
        [StringLength(50)] public string ManufacturerId { get; set; }
    }
}