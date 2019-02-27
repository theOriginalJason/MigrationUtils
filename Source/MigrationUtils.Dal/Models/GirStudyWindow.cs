using System;
namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindow : Audit
    {
        public int GirStudyWindowId { get; set; }

        public string Label { get; set; }

        public DateTimeOffset ApplicationOpenDate { get; set; }

        public DateTimeOffset ApplicationCloseDate { get; set; }

        public DateTimeOffset StudyStartDate { get; set; }

        public DateTimeOffset? ExpectedStudyCompletionDate { get; set; }

        public int TransmissionEntityId { get; set; }

        public DateTimeOffset? ActualStudyCompletionDate{ get; set; }

        public bool IsDeleted { get; set; }
    }
}