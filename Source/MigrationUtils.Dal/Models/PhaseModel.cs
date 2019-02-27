using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class PhaseModel
    {
        public int PhaseModelId { get; set; }

        [Required] [StringLength(200)] public string Name { get; set; }
    }
}