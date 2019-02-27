using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class NewStartProjectInterconnectionSpendStripYear
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NewStartProjectInterconnectionSpendStripYear()
        {
            NewStartProjectInterconnectionSpendStripYearCopyDifferences =
                new HashSet<NewStartProjectInterconnectionSpendStripYearCopyDifference>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewStartProjectInterconnectionSpendStripId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Year { get; set; }

        public int? SourceId { get; set; }

        [StringLength(50)] public string InterconnectionSpendTypeId { get; set; }

        public decimal? Amount { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public virtual InterconnectionSpendType InterconnectionSpendType { get; set; }

        public virtual NewStartProjectInterconnectionSpendStrip NewStartProjectInterconnectionSpendStrip { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NewStartProjectInterconnectionSpendStripYearCopyDifference>
            NewStartProjectInterconnectionSpendStripYearCopyDifferences { get; set; }
    }
}