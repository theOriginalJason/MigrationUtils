using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    [Table("ProjectLlcFilingStateStatuses")]
    public class ProjectLlcFilingStateStatus
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectLlcFilingStateStatus()
        {
            ProjectLlcFilingStates = new HashSet<ProjectLlcFilingState>();
        }

        [StringLength(50)] public string ProjectLlcFilingStateStatusId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectLlcFilingState> ProjectLlcFilingStates { get; set; }
    }
}