namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindowEventTemplate : Audit
    {
        public int GirStudyWindowEventTemplateId { get; set; }

        public string Designation { get; set; }

        public bool IsDeleted { get; set; }

        public int GirStudyWindowId { get; set; }

        public int TransmissionEntityEventTypeId { get; set; }

        public string Description { get; set; }
    }
}