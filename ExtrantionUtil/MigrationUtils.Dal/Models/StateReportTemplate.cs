using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class StateReportTemplate
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StateReportTemplate()
        {
            StateReportFilings = new HashSet<StateReportFiling>();
        }

        public int StateReportTemplateId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string State { get; set; }

        [Required] [StringLength(50)] public string DueDateInterval { get; set; }

        [Required] [StringLength(50)] public string FirstDueDateRule { get; set; }

        public DateTimeOffset? StateDeterminedDueDate { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StateReportFiling> StateReportFilings { get; set; }

        public virtual StateReportFirstDueDateRule StateReportFirstDueDateRule { get; set; }

        public virtual StateReportInterval StateReportInterval { get; set; }

        public virtual StateReportName StateReportName { get; set; }

        public virtual State State1 { get; set; }
    }
}