using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class PowerBiReportType
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PowerBiReportType()
        {
            PowerBiReports = new HashSet<PowerBiReport>();
        }

        [StringLength(50)] public string PowerBiReportTypeId { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PowerBiReport> PowerBiReports { get; set; }
    }
}