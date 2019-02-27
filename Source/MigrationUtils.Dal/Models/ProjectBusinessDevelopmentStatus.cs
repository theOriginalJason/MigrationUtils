using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    [Table("ProjectBusinessDevelopmentStatuses")]
    public class ProjectBusinessDevelopmentStatus
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectBusinessDevelopmentStatus()
        {
            Projects = new HashSet<Project>();
        }

        [StringLength(50)] public string ProjectBusinessDevelopmentStatusId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }
    }
}