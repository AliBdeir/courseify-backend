using Courseify.PdfMan.Exceptions;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;
using Courseify.PdfMan.Bookmarks.Data;

namespace Courseify.PdfMan.Text
{
    public class PdfTextService : IPdfTextService
    {
        public PdfTextService()
        {
        }
        public string ExtractTextFromChapter(PdfDocument pdfDoc, int chapterId, BookmarkNode storedBookmarks)
        {
            BookmarkNode node = storedBookmarks.FindNodeById(chapterId) ?? throw new ArgumentException("Chapter ID not found.");
            if (node.PageNumber == null) return string.Empty;

            int startPage = node.PageNumber.Value;
            int endPage;

            var nextNode = node.GetNextSibling(storedBookmarks);
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
                extractedText.AppendLine(ExtractTextFromPage(pdfDoc, i));
            }

            return extractedText.ToString();
        }

        public string ExtractTextFromPage(PdfDocument pdfDoc, int pageNumber)
        {
            return PdfTextExtractor.GetTextFromPage(pdfDoc.GetPage(pageNumber));
        }

        public string ExtractTextFromBookmarkNodes(BookmarkNode node)
        {
            StringBuilder text = new();
            void AddChildrenToText(BookmarkNode parent)
            {
                text.AppendLine(parent.Text);
                foreach (BookmarkNode item in parent!.Children)
                {
                    AddChildrenToText((BookmarkNode)item);
                }
            }
            AddChildrenToText(node);
            return text.ToString();
        }

    }
}
