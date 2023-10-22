using Courseify.PdfMan.Bookmarks.Data;
using Courseify.PdfMan.Text;
using iText.Kernel.Pdf;

namespace Courseify.PdfMan.Bookmarks
{
    public class PdfBookmarkService : IPdfBookmarkService
    {
        private readonly IPdfTextService? textService;
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

            BookmarkNode result = GetBookmarks(rootOutline, destTree, pdfDoc, includeText);

            return result;
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
                        if (textService == null)
                        {
                            throw new Exception("IPdfTextService must be provided if extracting text");
                        }
                        string text = textService.ExtractTextFromPage(pdfDoc, currentNode.PageNumber.Value);
                        currentNode.Text = text;
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
