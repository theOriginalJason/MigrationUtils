using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class Snap
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Snap()
        {
            CriticalMilestoneSnaps = new HashSet<CriticalMilestoneSnap>();
            EventSnaps = new HashSet<EventSnap>();
            InterconnectionSnaps = new HashSet<InterconnectionSnap>();
            PortfolioPlans = new HashSet<PortfolioPlan>();
            ProjectSnaps = new HashSet<ProjectSnap>();
            PwaSnaps = new HashSet<PwaSnap>();
            SubEventSnaps = new HashSet<SubEventSnap>();
            SubEventTypeSnaps = new HashSet<SubEventTypeSnap>();
            TransmissionEntityEventTypeSnaps = new HashSet<TransmissionEntityEventTypeSnap>();
            TransmissionEntitySnaps = new HashSet<TransmissionEntitySnap>();
        }

        public int SnapId { get; set; }

        public DateTimeOffset SnapDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [Required] [StringLength(200)] public string Description { get; set; }

        [Required] [StringLength(50)] public string SnapStatusTypeId { get; set; }

        [StringLength(2000)] public string StatusErrorMessage { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CriticalMilestoneSnap> CriticalMilestoneSnaps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventSnap> EventSnaps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterconnectionSnap> InterconnectionSnaps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlan> PortfolioPlans { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnap> ProjectSnaps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PwaSnap> PwaSnaps { get; set; }

        public virtual SnapStatusType SnapStatusType { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventSnap> SubEventSnaps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventTypeSnap> SubEventTypeSnaps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransmissionEntityEventTypeSnap> TransmissionEntityEventTypeSnaps { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransmissionEntitySnap> TransmissionEntitySnaps { get; set; }
    }
}