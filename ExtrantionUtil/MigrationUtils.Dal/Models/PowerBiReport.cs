using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class PowerBiReport
    {
        public int PowerBiReportId { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        [StringLength(2000)] public string Description { get; set; }

        [Required] [StringLength(2083)] public string Url { get; set; }

        public Guid ReportId { get; set; }

        [Required] [StringLength(50)] public string PowerBiReportTypeId { get; set; }

        [StringLength(200)] public string TargetTable { get; set; }

        [StringLength(200)] public string TargetColumn { get; set; }

        public virtual PowerBiReportType PowerBiReportType { get; set; }
    }
}