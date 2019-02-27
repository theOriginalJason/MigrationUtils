using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MigrationUtils.Dal.Models
{
    public class TransmissionEntityGroup
    {
        [SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransmissionEntityGroup()
        {
            Interconnections = new HashSet<Interconnection>();
        }

        public int TransmissionEntityGroupId { get; set; }

        [Required] [StringLength(200)] public string Name { get; set; }

        public int TransmissionEntityId { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Interconnection> Interconnections { get; set; }

        public virtual TransmissionEntity TransmissionEntity { get; set; }
    }
}