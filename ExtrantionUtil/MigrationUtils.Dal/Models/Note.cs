using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationUtils.Dal.Models
{
    public class Note
    {
        public int NoteId { get; set; }

        [Required] [StringLength(500)] public string NoteText { get; set; }

        [Required] [StringLength(50)] public string SubjectType { get; set; }

        public int SubjectId { get; set; }

        [Required] [StringLength(200)] public string CreatedBy { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        [StringLength(200)] public string UpdatedBy { get; set; }

        public DateTimeOffset? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; }

        [Required] [StringLength(100)] public string Title { get; set; }

        [StringLength(2083)] public string SubjectUrl { get; set; }

        public virtual NoteSubjectType NoteSubjectType { get; set; }
    }
}