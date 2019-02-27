using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class InterconnectionSnap
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InterconnectionId { get; set; }

        public string PoiDescription { get; set; }

        [Required] [StringLength(50)] public string State { get; set; }

        [StringLength(100)] public string IaIrOwner { get; set; }

        [StringLength(50)] public string Manufacturer { get; set; }

        [StringLength(50)] public string Model { get; set; }

        public decimal IaMw { get; set; }

        public decimal IaMwCommitted { get; set; }

        [StringLength(50)] public string AgreementNumber { get; set; }

        [StringLength(50)] public string AgreementDocument { get; set; }

        [StringLength(50)] public string ResourceDesignationType { get; set; }

        [Required] [StringLength(50)] public string ResourceType { get; set; }

        [StringLength(50)] public string GenNumber { get; set; }

        public int TransmissionEntityId { get; set; }

        public int TransmissionOwnerId { get; set; }

        public int ProjectId { get; set; }

        public decimal? Voltage { get; set; }

        [StringLength(50)] public string PoiCounty { get; set; }

        [StringLength(50)] public string Status { get; set; }

        public int? TransmissionEntityGroupId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsTemplate { get; set; }

        public int? ProjectLlcId { get; set; }

        public virtual Snap Snap { get; set; }
    }
}