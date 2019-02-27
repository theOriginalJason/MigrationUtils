using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class GirStudyWindow
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GirStudyWindow()
        {
            GirStudyWindowEventTemplates = new HashSet<GirStudyWindowEventTemplate>();
        }

        public int GirStudyWindowId { get; set; }

        [Required] [StringLength(50)] public string Label { get; set; }

        public DateTimeOffset ApplicationOpenDate { get; set; }

        public DateTimeOffset ApplicationCloseDate { get; set; }

        public int TransmissionEntityId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GirStudyWindowEventTemplate> GirStudyWindowEventTemplates { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }
    }
}