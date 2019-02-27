using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class State
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public State()
        {
            Interconnections = new HashSet<Interconnection>();
            NewStartProjects = new HashSet<NewStartProject>();
            ProjectLlcFilingStates = new HashSet<ProjectLlcFilingState>();
            Projects = new HashSet<Project>();
            StateReportTemplates = new HashSet<StateReportTemplate>();
        }

        [StringLength(50)] public string StateId { get; set; }

        [StringLength(50)] public string FileWith { get; set; }

        [StringLength(50)] public string PenaltyForNotFiling { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconnection> Interconnections { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProject> NewStartProjects { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectLlcFilingState> ProjectLlcFilingStates { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateReportTemplate> StateReportTemplates { get; set; }
    }
}