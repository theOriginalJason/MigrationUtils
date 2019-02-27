using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class SubEventConnection
    {
        public int SubEventConnectionId { get; set; }

        public int? ParentSubEventId { get; set; }

        public int ChildSubEventId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public int DayOffset { get; set; }

        public bool UseBusinessDays { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        public int? ParentEventId { get; set; }

        public bool AlwaysUseDueDate { get; set; }

        public virtual Event Event { get; set; }

        public virtual SubEvent SubEvent { get; set; }

        public virtual SubEvent SubEvent1 { get; set; }
    }
}