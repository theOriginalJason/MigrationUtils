using System;

namespace MigrationUtils.Dal.Models
{
    public class Snap
    {

        public int SnapId { get; set; }

        public DateTimeOffset SnapDate { get; set; }

        public string CreatedBy { get; set; }

        public string Description { get; set; }

        public string SnapStatusTypeId { get; set; }

        public string StatusErrorMessage { get; set; }
    }
}