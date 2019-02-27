using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class Phase
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phase()
        {
            NewStartProjectDevelopmentSpends = new HashSet<NewStartProjectDevelopmentSpend>();
            ProjectSnapDevelopmentSpends = new HashSet<ProjectSnapDevelopmentSpend>();
        }

        public int PhaseId { get; set; }

        [Required] [StringLength(200)] public string Name { get; set; }

        public decimal Amount { get; set; }

        public int PhaseModelId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectDevelopmentSpend> NewStartProjectDevelopmentSpends { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnapDevelopmentSpend> ProjectSnapDevelopmentSpends { get; set; }
    }
}