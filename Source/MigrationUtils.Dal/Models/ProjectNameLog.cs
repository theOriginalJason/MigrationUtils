using System;

namespace MigrationUtils.Dal.Models
{
    public class ProjectNameLog
    {
        public int ProjectNameLogId { get; set; }

        public string Name { get; set; }

        public int ProjectId { get; set; }

        public DateTimeOffset ChangeDate { get; set; }

        public string ChangedBy { get; set; }
    }
}