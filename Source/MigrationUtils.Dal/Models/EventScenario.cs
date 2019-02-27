using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class EventScenario
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventScenario()
        {
            SubEventScenarioConnections = new HashSet<SubEventScenarioConnection>();
            SubEventScenarios = new HashSet<SubEventScenario>();
        }

        public int EventScenarioId { get; set; }

        public int InterconnectionScenarioId { get; set; }

        public int? EventId { get; set; }

        [Column(TypeName = "money")] public decimal? Price { get; set; }

        public DateTimeOffset? StartDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        public DateTimeOffset? DeadlineDate { get; set; }

        [StringLength(50)] public string Description { get; set; }

        [StringLength(50)] public string Model { get; set; }

        [StringLength(50)] public string ResourceDesignationType { get; set; }

        public DateTimeOffset? CommercialOperatingDate { get; set; }

        [StringLength(50)] public string Manufacturer { get; set; }

        [StringLength(50)] public string Status { get; set; }

        public int? InterconnectionId { get; set; }

        [Column(TypeName = "money")] public decimal NonRefundableFunds { get; set; }

        public decimal? StudyMegawatts { get; set; }

        public DateTimeOffset? CompletedDate { get; set; }

        public int? TransmissionEntityEventTypeId { get; set; }

        [StringLength(50)] public string Designation { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual InterconnectionScenario InterconnectionScenario { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventScenarioConnection> SubEventScenarioConnections { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEventScenario> SubEventScenarios { get; set; }
    }
}