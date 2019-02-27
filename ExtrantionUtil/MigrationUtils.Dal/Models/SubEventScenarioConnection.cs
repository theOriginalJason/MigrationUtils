using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class SubEventScenarioConnection
    {
        public int SubEventScenarioConnectionId { get; set; }

        public int? ParentSubEventScenarioId { get; set; }

        public int ChildSubEventScenarioId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public int DayOffset { get; set; }

        public bool UseBusinessDays { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        public int? ParentEventScenarioId { get; set; }

        public bool AlwaysUseDueDate { get; set; }

        public virtual EventScenario EventScenario { get; set; }

        public virtual SubEventScenario SubEventScenario { get; set; }

        public virtual SubEventScenario SubEventScenario1 { get; set; }
    }
}