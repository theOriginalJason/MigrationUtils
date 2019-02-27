using System;

namespace MigrationUtils.Dal.Models
{
    public class PwaSnap
    {

        public int SnapId { get; set; }
        public string ProjectName { get; set; }

        public Guid ProjectUID { get; set; }

        public string TaskName { get; set; }

        public DateTimeOffset? Date { get; set; }

        public decimal? Forecast { get; set; }

        public decimal? Actuals { get; set; }

        public decimal? ProjectITD { get; set; }

        public decimal? ProjectYTD { get; set; }

        public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }
    }
}