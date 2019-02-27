namespace MigrationUtils.Dal.Models
{
    public class ProjectMilestoneName
    {
        public int ProjectMilestoneNameId { get; set; }
        public string Name { get; set; }
        public string ProjectTypeId { get; set; }
        public string ProjectMilestoneGroupId { get; set; }
    }
}