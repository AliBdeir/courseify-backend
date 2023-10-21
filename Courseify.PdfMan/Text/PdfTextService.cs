using Courseify.PdfMan.Exceptions;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

namespace Courseify.PdfMan.Text
{
    public class PdfTextService
    {
        private readonly BookmarkNode storedBookmarks;
        private readonly PdfReader reader;

        public PdfTextService(BookmarkNode storedBookmarks, PdfReader reader)
        {
            this.storedBookmarks = storedBookmarks ?? throw new ArgumentNullException(nameof(storedBookmarks));
            this.reader = reader;
        }
        public string ExtractTextFromChapter(int chapterId)
        {
            PdfDocument pdfDoc = new(this.reader);

            BookmarkNode node = storedBookmarks.FindNodeById(chapterId) ?? throw new ArgumentException("Chapter ID not found.");
            if (node.Children.Any())
                throw new NotALeafNodeException("The specified chapter ID does not point to a leaf node.");
            if (node.PageNumber == null) return string.Empty;
            int startPage = node.PageNumber.Value;
            int endPage;

            var nextNode = node.GetNextSibling();
            if (nextNode?.PageNumber != null)
            {
                endPage = nextNode.PageNumber.Value;
            }
            else
            {
                // If there is no next chapter, set endPage to the total number of pages in the PDF.
                endPage = pdfDoc.GetNumberOfPages() + 1;
            }

            StringBuilder extractedText = new();
            for (int i = startPage; i < endPage; i++)
            {
                extractedText.AppendLine(PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(i)));
            }

            pdfDoc.Close();

            return extractedText.ToString();
        }

    }
}
