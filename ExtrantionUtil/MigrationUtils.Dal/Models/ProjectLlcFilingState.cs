using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class ProjectLlcFilingState
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectLlcId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string StateId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ProjectLlcFilingStateTypeId { get; set; }

        public DateTimeOffset FilingDate { get; set; }

        [StringLength(50)] public string FilingStateId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(50)] public string Status { get; set; }

        public virtual ProjectLlcFilingStateStatus ProjectLlcFilingStateStatus { get; set; }

        public virtual ProjectLlcFilingStateType ProjectLlcFilingStateType { get; set; }

        public virtual ProjectLlc ProjectLlc { get; set; }

        public virtual State State { get; set; }
    }
}