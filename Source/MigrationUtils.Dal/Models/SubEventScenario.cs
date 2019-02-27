using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class SubEventScenario
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubEventScenario()
        {
            SubEventScenarioConnections = new HashSet<SubEventScenarioConnection>();
            SubEventScenarioConnections1 = new HashSet<SubEventScenarioConnection>();
        }

        public int SubEventScenarioId { get; set; }

        public int EventScenarioId { get; set; }

        public int? SubEventId { get; set; }

        public DateTimeOffset? DueDate { get; set; }

        public DateTimeOffset? ActualDate { get; set; }

        public DateTimeOffset? LcReleaseDate { get; set; }

        public DateTimeOffset? AtRiskDate { get; set; }

        [Column(TypeName = "money")] public decimal? Amount { get; set; }

        public int? EventId { get; set; }

        [StringLength(50)] public string PaymentType { get; set; }

        public int SubEventTypeId { get; set; }

        [Column(TypeName = "money")] public decimal? AmountExpensed { get; set; }

        [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "money")] public decimal? AmountRefundable { get; set; }

        public bool IsMonetary { get; set; }

        [StringLength(50)] public string EventTypeDesignation { get; set; }

        [StringLength(50)] public string MonetaryType { get; set; }

        [Required] [StringLength(50)] public string Status { get; set; }

        public DateTimeOffset? AtRiskReleaseDate { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public decimal? RateOfRefundability { get; set; }

        public virtual EventScenario EventScenario { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventScenarioConnection> SubEventScenarioConnections { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventScenarioConnection> SubEventScenarioConnections1 { get; set; }
    }
}