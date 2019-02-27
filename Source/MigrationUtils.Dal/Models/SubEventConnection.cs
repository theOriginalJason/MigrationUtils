namespace MigrationUtils.Dal.Models
{
    public class SubEventConnection
    {
        public int SubEventConnectionId { get; set; }

        public int? ParentSubEventId { get; set; }

        public int ChildSubEventId { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public int DayOffset { get; set; }

        public bool UseBusinessDays { get; set; }

        public string Type { get; set; }

        public int? ParentEventId { get; set; }

        public bool AlwaysUseDueDate { get; set; }
    }
}