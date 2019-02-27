using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProjectLlc
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectLlc()
        {
            Interconnections = new HashSet<Interconnection>();
            ProjectLlcFilingStates = new HashSet<ProjectLlcFilingState>();
            Projects = new HashSet<Project>();
            StateReportFilings = new HashSet<StateReportFiling>();
        }

        public int ProjectLlcId { get; set; }

        [Required] [StringLength(200)] public string Name { get; set; }

        [StringLength(4)] public string DaxId { get; set; }

        [StringLength(1000)] public string FormationState { get; set; }

        [StringLength(1000)] public string QualificationState { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsShelfEntity { get; set; }

        [StringLength(50)] public string FormationStatus { get; set; }

        [StringLength(1000)] public string QualificationStatus { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconnection> Interconnections { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectLlcFilingState> ProjectLlcFilingStates { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateReportFiling> StateReportFilings { get; set; }
    }
}