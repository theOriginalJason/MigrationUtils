using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class DevelopmentSpendType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DevelopmentSpendType()
        {
            NewStartProjectDevelopmentSpends = new HashSet<NewStartProjectDevelopmentSpend>();
            ProjectSnapDevelopmentSpends = new HashSet<ProjectSnapDevelopmentSpend>();
        }

        [StringLength(50)] public string DevelopmentSpendTypeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectDevelopmentSpend> NewStartProjectDevelopmentSpends { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnapDevelopmentSpend> ProjectSnapDevelopmentSpends { get; set; }
    }
}