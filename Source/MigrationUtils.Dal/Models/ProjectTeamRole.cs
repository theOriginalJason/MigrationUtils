using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProjectTeamRole
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectTeamRole()
        {
            ProjectTeamMembers = new HashSet<ProjectTeamMember>();
        }

        [StringLength(50)] public string ProjectTeamRoleId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectTeamMember> ProjectTeamMembers { get; set; }
    }
}