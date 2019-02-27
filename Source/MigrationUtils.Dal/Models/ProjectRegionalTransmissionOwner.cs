using System;

namespace MigrationUtils.Dal.Models
{
    public class ProjectRegionalTransmissionOwner
    {
        public int ProjectId { get; set; }

        public int RegionalTransmissionOwnerId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedBy { get; set; }
    }
}