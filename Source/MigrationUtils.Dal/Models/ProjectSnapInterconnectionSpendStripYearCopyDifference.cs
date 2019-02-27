using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class ProjectSnapInterconnectionSpendStripYearCopyDifference
    {
        public int ProjectSnapInterconnectionSpendStripYearCopyDifferenceId { get; set; }

        public int ProjectSnapInterconnectionSpendStripId { get; set; }

        public int Year { get; set; }

        public bool? NeedsAction { get; set; }

        [Required] [StringLength(500)] public string Description { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public virtual ProjectSnapInterconnectionSpendStripYear ProjectSnapInterconnectionSpendStripYear { get; set; }
    }
}