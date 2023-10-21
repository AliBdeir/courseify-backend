using iText.Kernel.Pdf;
using System.Reflection.PortableExecutable;

namespace Courseify.PdfMan
{
    public class PdfBookmarkService : IPdfBookmarkService
    {
        public Dictionary<string, int> GetBookmarksFromPdf(string inputFilePath)
        {
            using PdfReader reader = new(inputFilePath);
            PdfDocument pdfDoc = new(reader);

            PdfOutline rootOutline = pdfDoc.GetOutlines(false);
            IPdfNameTreeAccess destTree = pdfDoc.GetCatalog().GetNameTree(PdfName.Dests);
            var bookmarks = GetBookmarks(rootOutline, destTree, pdfDoc);

            pdfDoc.Close();

            return bookmarks;
        }

        private Dictionary<string, int> GetBookmarks(PdfOutline outline, IPdfNameTreeAccess names, PdfDocument pdfDoc)
        {
            Dictionary<string, int> bookmarks = new();

            if (outline.GetDestination() != null)
            {
                var pagenum = pdfDoc.GetPageNumber((PdfDictionary)outline.GetDestination().GetDestinationPage(names));
                bookmarks.Add(outline.GetTitle(), pagenum);
            }

            foreach (var child in outline.GetAllChildren())
            {
                var childBookmarks = GetBookmarks(child, names, pdfDoc);
                bookmarks = bookmarks.Union(childBookmarks).ToDictionary(k => k.Key, v => v.Value);
            }

            return bookmarks;
        }
    }
}