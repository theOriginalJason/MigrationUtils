using System;

namespace MigrationUtils.Dal.Models
{
    public class PowerBiReport
    {
        public int PowerBiReportId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public Guid ReportId { get; set; }

        public string PowerBiReportTypeId { get; set; }

        public string TargetTable { get; set; }

        public string TargetColumn { get; set; }
    }
}