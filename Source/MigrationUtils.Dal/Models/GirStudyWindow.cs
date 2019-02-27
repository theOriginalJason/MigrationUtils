using System;
namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindow
    {
        public int GirStudyWindowId { get; set; }

        public string Label { get; set; }

        public DateTimeOffset ApplicationOpenDate { get; set; }

        public DateTimeOffset ApplicationCloseDate { get; set; }

        public DateTimeOffset StudyStartDate { get; set; }

        public DateTimeOffset? ExpectedStudyCompletionDate { get; set; }

        public int TransmissionEntityId { get; set; }

        public DateTimeOffset? ActualStudyCompletionDate{ get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}