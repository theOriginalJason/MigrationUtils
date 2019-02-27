using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class ProjectSnap
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectSnap()
        {
            PortfolioPlanProjectSnaps = new HashSet<PortfolioPlanProjectSnap>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SnapId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        public DateTimeOffset? ActualCod { get; set; }

        public DateTimeOffset? EarliestCod { get; set; }

        [Required] [StringLength(50)] public string Status { get; set; }

        [Required] [StringLength(50)] public string PriorityStatus { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)] public string County { get; set; }

        [StringLength(50)] public string State { get; set; }

        [StringLength(50)] public string Region { get; set; }

        public decimal? Size { get; set; }

        public decimal? SiteSecured { get; set; }

        public decimal? RowSecured { get; set; }

        [StringLength(50)] public string BusinessDevelopmentStatus { get; set; }

        public DateTimeOffset? PlannedCod { get; set; }

        public int? ProjectLlcId { get; set; }

        public DateTimeOffset? BudgetedCOD { get; set; }

        public bool IsBiddable { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PortfolioPlanProjectSnap> PortfolioPlanProjectSnaps { get; set; }

        public virtual Snap Snap { get; set; }
    }
}