using Courseify.PdfMan.Bookmarks.Data;
using iText.Kernel.Pdf;

namespace Courseify.PdfMan.Bookmarks
{
    public interface IPdfBookmarkService
    {
        /// <summary>
        /// Gets the bookmarks from a pdf file
        /// </summary>
        /// <param name="inputFilePath">The path to the PDF file</param>
        /// <returns>Dictionary with the name of each bookmark and the page it starts at</returns>
        BookmarkNode GetBookmarksFromPdf(PdfDocument pdf, bool includeText);

        
    }
}