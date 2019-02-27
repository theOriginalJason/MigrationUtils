using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    public class ProjectWriteUp
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProposalWriteUpTypeId { get; set; }

        public bool IsDeleted { get; set; }

        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(50)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(50)] public string UpdatedBy { get; set; }

        public virtual Project Project { get; set; }

        public virtual ProposalWriteUpType ProposalWriteUpType { get; set; }
    }
}