using iText.Kernel.Pdf;
using System.Collections.Generic;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

namespace Courseify.PdfMan.Bookmarks
{
    public class PdfBookmarkService : IPdfBookmarkService
    {
        private BookmarkNode? storedBookmarks = null; // Member to store the bookmarks
        private int currentID = 1; // Start from ID 1

        public BookmarkNode GetBookmarksFromPdf(string inputFilePath)
        {
            using PdfReader reader = new(inputFilePath);
            PdfDocument pdfDoc = new(reader);

            PdfOutline rootOutline = pdfDoc.GetOutlines(false);
            IPdfNameTreeAccess destTree = pdfDoc.GetCatalog().GetNameTree(PdfName.Dests);

            // Resetting the ID for each new PDF
            currentID = 1;

            storedBookmarks = GetBookmarks(rootOutline, destTree, pdfDoc);

            pdfDoc.Close();

            return storedBookmarks;
        }

        private BookmarkNode GetBookmarks(PdfOutline outline, IPdfNameTreeAccess names, PdfDocument pdfDoc)
        {
            BookmarkNode currentNode = new()
            {
                Id = currentID++, // Assign the current ID and then increment it
                Title = outline.GetTitle()
            };

            if (outline.GetDestination() != null)
            {
                PdfDictionary destinationPage = (PdfDictionary)outline.GetDestination().GetDestinationPage(names);
                if (destinationPage != null)
                {
                    currentNode.PageNumber = pdfDoc.GetPageNumber(destinationPage);
                }
            }

            foreach (var child in outline.GetAllChildren())
            {
                currentNode.Children.Add(GetBookmarks(child, names, pdfDoc));
            }

            return currentNode;
        }   



    }
}
