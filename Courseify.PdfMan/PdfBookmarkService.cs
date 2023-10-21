using iText.Kernel.Pdf;
using System.Collections.Generic;
using static Courseify.PdfMan.IPdfBookmarkService;

namespace Courseify.PdfMan
{
    public class PdfBookmarkService : IPdfBookmarkService
    {
        public BookmarkNode GetBookmarksFromPdf(string inputFilePath)
        {
            using PdfReader reader = new(inputFilePath);
            PdfDocument pdfDoc = new(reader);

            PdfOutline rootOutline = pdfDoc.GetOutlines(false);
            IPdfNameTreeAccess destTree = pdfDoc.GetCatalog().GetNameTree(PdfName.Dests);
            var bookmarks = GetBookmarks(rootOutline, destTree, pdfDoc);

            pdfDoc.Close();

            return bookmarks;
        }

        private BookmarkNode GetBookmarks(PdfOutline outline, IPdfNameTreeAccess names, PdfDocument pdfDoc)
        {
            BookmarkNode currentNode = new()
            {
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
