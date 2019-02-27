using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class InterconnectionScenarioFinalOutcome
    {
        [StringLength(50)] public string InterconnectionScenarioFinalOutcomeId { get; set; }
    }
}