using Courseify.PdfMan.Bookmarks;

namespace Courseify.DataAccessLayer
{
    public interface ISessionDatabaseService
    {
        Task<string> GenerateSession(IPdfBookmarkService.BookmarkNode node);
    }
}