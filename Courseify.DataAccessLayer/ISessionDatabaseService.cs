using Courseify.PdfMan.Bookmarks;
using Courseify.PdfMan.Bookmarks.Data;

namespace Courseify.DataAccessLayer
{
    public interface ISessionDatabaseService
    {
        Task<string> GenerateSession(BookmarkNode node);
        Task<BookmarkNode> GetSession(string sessionId);
    }
}