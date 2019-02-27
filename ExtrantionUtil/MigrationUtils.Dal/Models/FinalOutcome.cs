using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class FinalOutcome
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FinalOutcome()
        {
            PortfolioPlanNewStartProjects = new HashSet<PortfolioPlanNewStartProject>();
            PortfolioPlanProjectSnaps = new HashSet<PortfolioPlanProjectSnap>();
        }

        [StringLength(50)] public string FinalOutcomeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanNewStartProject> PortfolioPlanNewStartProjects { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanProjectSnap> PortfolioPlanProjectSnaps { get; set; }
    }
}