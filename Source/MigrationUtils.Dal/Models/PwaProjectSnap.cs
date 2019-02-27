using System;

namespace MigrationUtils.Dal.Models
{
    public class PwaProjectSnap
    {
        public int SnapId { get; set; }

        public Guid ProjectUID { get; set; }

        public string ProjectName { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public int? HorizonProjectId { get; set; }
    }
}