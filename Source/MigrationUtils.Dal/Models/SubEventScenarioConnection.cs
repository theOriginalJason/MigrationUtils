namespace MigrationUtils.Dal.Models
{
    public class SubEventScenarioConnection
    {
        public int SubEventScenarioConnectionId { get; set; }

        public int? ParentSubEventScenarioId { get; set; }

        public int ChildSubEventScenarioId { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public int DayOffset { get; set; }

        public bool UseBusinessDays { get; set; }

        public string Type { get; set; }

        public int? ParentEventScenarioId { get; set; }

        public bool AlwaysUseDueDate { get; set; }
    }
}