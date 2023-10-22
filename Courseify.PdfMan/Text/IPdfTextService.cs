using Courseify.PdfMan.Bookmarks.Data;
using iText.Kernel.Pdf;

namespace Courseify.PdfMan.Text
{
    public interface IPdfTextService
    {
        string ExtractTextFromBookmarkNodes(BookmarkNodeWithText node);
        string ExtractTextFromChapter(PdfDocument doc, int chapterId, BookmarkNode storedBookmarks);
        string ExtractTextFromPage(PdfDocument pdfDoc, int pageNumber);
    }
}