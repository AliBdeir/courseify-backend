// See https://aka.ms/new-console-template for more information
using Courseify.PdfMan;
using static Courseify.PdfMan.IPdfBookmarkService;
// Input PDF 
PdfBookmarkService bookmarkService = new PdfBookmarkService();
String PdfFilePath = "C:\\Users\\benda\\Downloads\\PHYSICS 150 BOOK.pdf";
var bookmarkReturn = bookmarkService.GetBookmarksFromPdf(PdfFilePath);
tabsforchildren(bookmarkReturn);
// Go trhoigh the list of nodes using a for loop 
void tabsforchildren(BookmarkNode Node, int indentation =0)
{
    Console.WriteLine(new string('\t', indentation) + Node.Title);
    foreach (var item in Node.Children)
    {
        tabsforchildren(item, indentation+1);
    }
}
