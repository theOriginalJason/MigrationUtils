using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class StateReportTemplate
    {
        public int StateReportTemplateId { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public string DueDateInterval { get; set; }

        public string FirstDueDateRule { get; set; }

        public DateTimeOffset? StateDeterminedDueDate { get; set; }

    }
}