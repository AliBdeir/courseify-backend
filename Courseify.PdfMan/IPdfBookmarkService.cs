namespace Courseify.PdfMan
{
    public interface IPdfBookmarkService
    {
        /// <summary>
        /// Gets the bookmarks from a pdf file
        /// </summary>
        /// <param name="inputFilePath">The path to the PDF file</param>
        /// <returns>Dictionary with the name of each bookmark and the page it starts at</returns>
        BookmarkNode GetBookmarksFromPdf(string inputFilePath);

        public class BookmarkNode
        {
            public required string Title { get; set; }
            public int? PageNumber { get; set; }
            public List<BookmarkNode> Children { get; set; } = new List<BookmarkNode>();
        }
    }
}   