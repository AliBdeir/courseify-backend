using Courseify.PdfMan.Bookmarks.Data;

namespace CourseifyBackend.Data.SessionOverview
{
    public class SessionOverview
    {
        public required Guid Id { get; set; }
        public required string Title { get; set; }
        public int? PageNumber { get; set; }
        public string? Text { get; set; }
    }
}
