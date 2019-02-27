using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class Project
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            CriticalMilestones = new HashSet<CriticalMilestone>();
            Interconnections = new HashSet<Interconnection>();
            Issues = new HashSet<Issue>();
            ProjectNameLogs = new HashSet<ProjectNameLog>();
            ProjectRegionalTransmissionOwners = new HashSet<ProjectRegionalTransmissionOwner>();
            ProjectRisks = new HashSet<ProjectRisk>();
            ProjectTeamMembers = new HashSet<ProjectTeamMember>();
            ProjectWriteUps = new HashSet<ProjectWriteUp>();
            Proposals = new HashSet<Proposal>();
            Swots = new HashSet<Swot>();
        }

        public int ProjectId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        public DateTimeOffset? ActualCod { get; set; }

        public DateTimeOffset? EarliestCod { get; set; }

        [Required] [StringLength(50)] public string Status { get; set; }

        [Required] [StringLength(50)] public string PriorityStatus { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)] public string County { get; set; }

        [StringLength(50)] public string State { get; set; }

        [StringLength(50)] public string Region { get; set; }

        public decimal? Size { get; set; }

        public decimal? SiteSecured { get; set; }

        public decimal? RowSecured { get; set; }

        [StringLength(50)] public string BusinessDevelopmentStatus { get; set; }

        public int? RegionalTransmissionOwnerId { get; set; }

        public DateTimeOffset? PlannedCod { get; set; }

        public int? ProjectLlcId { get; set; }

        public DateTimeOffset? BudgetedCOD { get; set; }

        public bool IsBiddable { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CriticalMilestone> CriticalMilestones { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconnection> Interconnections { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Issue> Issues { get; set; }

        public virtual ProjectBusinessDevelopmentStatus ProjectBusinessDevelopmentStatus { get; set; }

        public virtual ProjectLlc ProjectLlc { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectNameLog> ProjectNameLogs { get; set; }

        public virtual ProjectPriorityStatus ProjectPriorityStatus { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectRegionalTransmissionOwner> ProjectRegionalTransmissionOwners { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectRisk> ProjectRisks { get; set; }

        public virtual ProjectStatus ProjectStatus { get; set; }

        public virtual ProjectType ProjectType { get; set; }

        public virtual Region Region1 { get; set; }

        public virtual State State1 { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectTeamMember> ProjectTeamMembers { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectWriteUp> ProjectWriteUps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Proposal> Proposals { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Swot> Swots { get; set; }
    }
}