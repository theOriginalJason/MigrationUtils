using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class ProjectRisk
    {
        public int ProjectRiskId { get; set; }

        public int ProjectId { get; set; }

        [Required] [StringLength(50)] public string ProjectRiskCategory { get; set; }

        [Required] [StringLength(50)] public string ProjectRiskLevel { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public virtual ProjectRiskCategory ProjectRiskCategory1 { get; set; }

        public virtual ProjectRiskLevel ProjectRiskLevel1 { get; set; }

        public virtual Project Project { get; set; }
    }
}