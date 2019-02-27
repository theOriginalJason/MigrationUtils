using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanProjectSnapCopyDifference
    {
        public int PortfolioPlanProjectSnapCopyDifferenceId { get; set; }

        public int? PortfolioPlanId { get; set; }

        public int? ProjectId { get; set; }

        public int? SnapId { get; set; }

        public bool? NeedsAction { get; set; }

        [Required] [StringLength(500)] public string Description { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }
    }
}