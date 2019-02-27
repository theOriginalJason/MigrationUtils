namespace MigrationUtils.Dal.Models
{
    public class Phase
    {

        public int PhaseId { get; set; }

        public string Name { get; set; }

        public decimal Amount { get; set; }

        public int PhaseModelId { get; set; }
    }
}