using System;

namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindowSubEventTemplate : Audit
    {
        public int GirStudyWindowSubEventTemplateId { get; set; }

        public string Name { get; set; }

        public int SubEventTypeId { get; set; }

        public int GirStudyWindowEventTemplateId { get; set; }

        public DateTimeOffset TpInitialDueDate { get; set; }

        public DateTimeOffset TpProjectedDate { get; set; }

        public DateTimeOffset TweExpectedDate { get; set; }

        public DateTimeOffset? ActualDate { get; set; }

        public DateTimeOffset? AtRiskDate { get; set; }

    }
}