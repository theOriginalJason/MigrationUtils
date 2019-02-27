namespace MigrationUtils.Dal.Models
{
    public class Note:Audit
    {
        public int NoteId { get; set; }

        public string NoteText { get; set; }

        public string SubjectType { get; set; }

        public int SubjectId { get; set; }

        public bool IsDeleted { get; set; }

        public string Title { get; set; }

        public string SubjectUrl { get; set; }

        public virtual NoteSubjectType NoteSubjectType { get; set; }
    }
}