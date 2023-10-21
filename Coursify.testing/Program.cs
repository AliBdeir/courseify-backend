// See https://aka.ms/new-console-template for more information
// Input PDF 
using Courseify.PdfMan.Bookmarks;
using iText.StyledXmlParser.Jsoup.Nodes;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

PdfBookmarkService bookmarkService = new PdfBookmarkService();
string PdfFilePath = "C:\\Users\\benda\\Downloads\\PHYSICS 150 BOOK.pdf";
var bookmarkReturn = bookmarkService.GetBookmarksFromPdf(PdfFilePath);
tabsforchildren(bookmarkReturn);
// Go trhoigh the list of nodes using a for loop 
void tabsforchildren(BookmarkNode Node, int indentation = 0)
{
    Console.WriteLine(new string('\t', indentation) + $"{Node.Title} ({Node.Id})");

    foreach (var item in Node.Children)
    {
        tabsforchildren(item, indentation + 1);
    }
}
