using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class EventSnap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventId { get; set; }

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

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public DateTimeOffset? CompletedDate { get; set; }

        public int? TransmissionEntityEventTypeId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsTemplate { get; set; }

        [StringLength(50)] public string Designation { get; set; }

        public int? GirStudyWindowEventTemplateId { get; set; }

        public virtual Snap Snap { get; set; }
    }
}