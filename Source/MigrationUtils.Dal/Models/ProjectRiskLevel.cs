using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProjectRiskLevel
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectRiskLevel()
        {
            NewStartProjectRisks = new HashSet<NewStartProjectRisk>();
            ProjectRisks = new HashSet<ProjectRisk>();
        }

        [StringLength(50)] public string ProjectRiskLevelId { get; set; }

        public int OrderIndex { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectRisk> NewStartProjectRisks { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectRisk> ProjectRisks { get; set; }
    }
}