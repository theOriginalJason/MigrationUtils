using System;
namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanCopy
    {
        public int OldPortfolioPlanId { get; set; }
        
        public int NewPortfolioPlanId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string CopyStatusId { get; set; }

        public string ErrorMessage { get; set; }
    }
}