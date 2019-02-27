namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanCopyDifference :Audit
    {
        public int PortfolioPlanCopyDifferenceId { get; set; }
        public int OldPortfolioPlanId { get; set; }
        public int NewPortfolioPlanId { get; set; }
        public string PortfolioPlanCopyModelTypeId { get; set; }
        public string PortfolioPlanCopyDifferenceTypeId { get; set; }
        public string Message { get; set; }
        public bool? Checked { get; set; }
    }
}