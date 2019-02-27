using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class State
    {
        public string StateId { get; set; }

        public string FileWith { get; set; }

        public string PenaltyForNotFiling { get; set; }
    }
}