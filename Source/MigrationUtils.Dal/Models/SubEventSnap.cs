using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class SubEventSnap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public DateTimeOffset? TweExpectedDate { get; set; }

        public DateTimeOffset? TpProjectedDate { get; set; }

        public DateTimeOffset? TpInitialDueDate { get; set; }

        public int? GirStudyWindowSubEventTemplateId { get; set; }

        public virtual Snap Snap { get; set; }
    }
}