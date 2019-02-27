using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class PortfolioPlanProjectSnap
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PortfolioPlanProjectSnap()
        {
            ProjectSnapDevelopmentSpends = new HashSet<ProjectSnapDevelopmentSpend>();
            ProjectSnapInterconnectionSpendStrips = new HashSet<ProjectSnapInterconnectionSpendStrip>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PortfolioPlanId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(50)] public string FinalOutcome { get; set; }

        public DateTimeOffset? FinalOutcomeDate { get; set; }

        public virtual FinalOutcome FinalOutcome1 { get; set; }

        public virtual PortfolioPlan PortfolioPlan { get; set; }

        public virtual ProjectSnap ProjectSnap { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnapDevelopmentSpend> ProjectSnapDevelopmentSpends { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectSnapInterconnectionSpendStrip> ProjectSnapInterconnectionSpendStrips
        {
            get;
            set;
        }
    }
}