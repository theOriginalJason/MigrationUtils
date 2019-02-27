using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProject
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewStartProject()
        {
            NewStartProjectCriticalMilestones = new HashSet<NewStartProjectCriticalMilestone>();
            NewStartProjectDevelopmentSpends = new HashSet<NewStartProjectDevelopmentSpend>();
            NewStartProjectRisks = new HashSet<NewStartProjectRisk>();
            PortfolioPlanNewStartProjects = new HashSet<PortfolioPlanNewStartProject>();
        }

        public int NewStartProjectId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        [StringLength(50)] public string State { get; set; }

        [StringLength(50)] public string Region { get; set; }

        public decimal? Size { get; set; }

        public int RegionalTransmissionOwnerId { get; set; }

        public DateTimeOffset? BudgetedCOD { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedOn { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectCriticalMilestone> NewStartProjectCriticalMilestones { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectDevelopmentSpend> NewStartProjectDevelopmentSpends { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectRisk> NewStartProjectRisks { get; set; }

        public virtual ProjectType ProjectType { get; set; }

        public virtual Region Region1 { get; set; }

        public virtual State State1 { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanNewStartProject> PortfolioPlanNewStartProjects { get; set; }
    }
}