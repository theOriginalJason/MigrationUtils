using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanScheduleEntry
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PortfolioPlanScheduleEntry()
        {
            NewStartProjectDevelopmentSpends = new HashSet<NewStartProjectDevelopmentSpend>();
            ProjectSnapDevelopmentSpends = new HashSet<ProjectSnapDevelopmentSpend>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PortfolioPlanId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        public decimal CodMw { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectDevelopmentSpend> NewStartProjectDevelopmentSpends { get; set; }

        public virtual PortfolioPlan PortfolioPlan { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnapDevelopmentSpend> ProjectSnapDevelopmentSpends { get; set; }
    }
}