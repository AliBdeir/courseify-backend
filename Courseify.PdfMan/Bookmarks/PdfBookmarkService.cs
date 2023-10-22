using Courseify.PdfMan.Bookmarks.Data;
using Courseify.PdfMan.Text;
using iText.Kernel.Pdf;

namespace Courseify.PdfMan.Bookmarks
{
    public class PdfBookmarkService : IPdfBookmarkService
    {
        private readonly IPdfTextService? textService;
        private BookmarkNode? storedBookmarks = null; // Member to store the bookmarks
        private int currentID = 1; // Start from ID 1

        public PdfBookmarkService(IPdfTextService? textService)
        {
            this.textService = textService;
        }

        public BookmarkNode GetBookmarksFromPdf(PdfDocument pdfDoc, bool includeText)
        {
            if (includeText && textService == null)
            {
                throw new Exception("Pdf Text Service must be injected if text is to be included in parsing");
            }
            PdfOutline rootOutline = pdfDoc.GetOutlines(false);
            IPdfNameTreeAccess destTree = pdfDoc.GetCatalog().GetNameTree(PdfName.Dests);

            // Resetting the ID for each new PDF
            currentID = 1;

            storedBookmarks = GetBookmarks(rootOutline, destTree, pdfDoc, includeText);

            return storedBookmarks;
        }

        private BookmarkNode GetBookmarks(PdfOutline root, IPdfNameTreeAccess names, PdfDocument pdfDoc, bool includeText)
        {
            BookmarkNode currentNode = new()
            {
                Id = currentID++, // Assign the current ID and then increment it
                Title = root.GetTitle(),
            };

            if (root.GetDestination() != null)
            {
                PdfDictionary destinationPage = (PdfDictionary)root.GetDestination().GetDestinationPage(names);
                if (destinationPage != null)
                {
                    currentNode.PageNumber = pdfDoc.GetPageNumber(destinationPage);
                    if (includeText && currentNode.PageNumber.HasValue)
                    {
                        string text = textService.ExtractTextFromPage(pdfDoc, currentNode.PageNumber.Value);
                        currentNode = new BookmarkNodeWithText(currentNode, text);
                    }
                }
            }

            foreach (var child in root.GetAllChildren())
            {
                currentNode.Children.Add(GetBookmarks(child, names, pdfDoc, includeText));
            }

            return currentNode;
        }   



    }
}
