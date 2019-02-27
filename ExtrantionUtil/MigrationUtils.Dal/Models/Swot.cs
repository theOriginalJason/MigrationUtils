using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class Swot
    {
        public int SwotId { get; set; }

        [Required] [StringLength(50)] public string SwotTypeId { get; set; }

        public int ProjectId { get; set; }

        [Required] [StringLength(1000)] public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Project Project { get; set; }

        public virtual SwotType SwotType { get; set; }
    }
}