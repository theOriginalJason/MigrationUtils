using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MigrationUtils.Dal.Models
{
    [Table("FileMetadata")]
    public class FileMetadata
    {
        public int FileMetadataId { get; set; }

        public string SubjectType { get; set; }

        public string SubjectId { get; set; }

        public string PrefixedFileName { get; set; }

        public string FileName { get; set; }

        public string Title { get; set; }

        public string Submitter { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}