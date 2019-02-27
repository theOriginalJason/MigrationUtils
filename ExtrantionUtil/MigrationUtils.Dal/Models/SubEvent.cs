using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class SubEvent
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubEvent()
        {
            SubEventAlerts = new HashSet<SubEventAlert>();
            SubEventConnections = new HashSet<SubEventConnection>();
            SubEventConnections1 = new HashSet<SubEventConnection>();
        }

        public int SubEventId { get; set; }

        public DateTimeOffset? ActualDate { get; set; }

        public DateTimeOffset? LcReleaseDate { get; set; }

        public DateTimeOffset? AtRiskDate { get; set; }

        [Column(TypeName = "money")] public decimal? Amount { get; set; }

        public int EventId { get; set; }

        [StringLength(50)] public string PaymentType { get; set; }

        public int SubEventTypeId { get; set; }

        [Column(TypeName = "money")] public decimal? AmountExpensed { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "money")] public decimal? AmountRefundable { get; set; }

        public bool IsTemplate { get; set; }

        public bool IsMonetary { get; set; }

        [StringLength(50)] public string EventTypeDesignation { get; set; }

        [StringLength(50)] public string MonetaryType { get; set; }

        [Required] [StringLength(50)] public string Status { get; set; }

        public DateTimeOffset? AtRiskReleaseDate { get; set; }

        public int? GirStudyWindowSubEventTemplateId { get; set; }

        public DateTimeOffset TweExpectedDate { get; set; }

        public DateTimeOffset TpInitialDueDate { get; set; }

        public DateTimeOffset TpProjectedDate { get; set; }

        public virtual Event Event { get; set; }

        public virtual GirStudyWindowSubEventTemplate GirStudyWindowSubEventTemplate { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventAlert> SubEventAlerts { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventConnection> SubEventConnections { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventConnection> SubEventConnections1 { get; set; }

        public virtual SubEventIssuePriority SubEventIssuePriority { get; set; }

        public virtual SubEventStatus SubEventStatus { get; set; }

        public virtual SubEventType SubEventType { get; set; }
    }
}