using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    [Table("FileMetadata")]
    public class FileMetadata
    {
        public int FileMetadataId { get; set; }

        [Required] [StringLength(100)] public string SubjectType { get; set; }

        [Required] [StringLength(200)] public string SubjectId { get; set; }

        [Required] [StringLength(1000)] public string PrefixedFileName { get; set; }

        [Required] [StringLength(1000)] public string FileName { get; set; }

        [StringLength(1000)] public string Title { get; set; }

        [Required] [StringLength(200)] public string Submitter { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")] public DateTime CreatedOn { get; set; }

        [Required] [StringLength(200)] public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")] public DateTime UpdatedOn { get; set; }
    }
}