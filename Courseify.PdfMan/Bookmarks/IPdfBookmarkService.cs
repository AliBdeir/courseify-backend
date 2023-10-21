namespace Courseify.PdfMan.Bookmarks
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
            public required int Id { get; set; }
            public required string Title { get; set; }
            public int? PageNumber { get; set; }
            public List<BookmarkNode> Children { get; set; } = new List<BookmarkNode>();

            public BookmarkNode? GetNextSibling()
            {
                BookmarkNode? parent = GetParent();
                if (parent == null)
                    return null;  // This is the root node or an orphaned node

                BookmarkNode? previousNode = null;
                foreach (var child in parent.Children)
                {
                    if (previousNode != null && previousNode.Id == Id)
                        return child;

                    previousNode = child;
                }

                return null;
            }

            public BookmarkNode? GetParent(BookmarkNode? root = null)
            {
                if (root == null)
                    return null;

                if (root.Children.Contains(this))
                    return root;

                foreach (var child in root.Children)
                {
                    var potentialParent = GetParent(child);
                    if (potentialParent != null)
                        return potentialParent;
                }

                return null;
            }

            public BookmarkNode? FindNodeById(int id)
            {
                if (this.Id == id)
                    return this;

                foreach (var child in Children)
                {
                    var found = child.FindNodeById(id);
                    if (found != null)
                        return found;
                }

                return null;
            }

        }
    }
}