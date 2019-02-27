using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProjectLlcFilingStateType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectLlcFilingStateType()
        {
            ProjectLlcFilingStates = new HashSet<ProjectLlcFilingState>();
        }

        [StringLength(50)] public string ProjectLlcFilingStateTypeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectLlcFilingState> ProjectLlcFilingStates { get; set; }
    }
}