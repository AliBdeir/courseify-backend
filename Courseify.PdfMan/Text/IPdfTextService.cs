using iText.Kernel.Pdf;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

namespace Courseify.PdfMan.Text
{
    public interface IPdfTextService
    {
        string ExtractTextFromChapter(PdfDocument doc, int chapterId, BookmarkNode storedBookmarks);
    }
}