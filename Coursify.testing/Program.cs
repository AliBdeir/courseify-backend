//// See https://aka.ms/new-console-template for more information
//// Input PDF 
//using Courseify.PdfMan.Bookmarks;
//using Courseify.PdfMan.Text;
//using iText.Kernel.Pdf;
//using iText.StyledXmlParser.Jsoup.Nodes;
//using System.Diagnostics;
//using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

//PdfBookmarkService bookmarkService = new PdfBookmarkService();
//string PdfFilePath = "C:\\Users\\MSE\\Downloads\\PHYSICS 150 BOOK.pdf";
//using PdfReader reader = new PdfReader(PdfFilePath);
//PdfDocument doc = new(reader);
//var bookmarks = bookmarkService.GetBookmarksFromPdf(doc);
//tabsforchildren(bookmarks);
//// Go trhoigh the list of nodes using a for loop 
//void tabsforchildren(BookmarkNode Node, int indentation = 0)
//{
//    Console.WriteLine(new string('\t', indentation) + $"{Node.Title} ({Node.Id})");

//    foreach (var item in Node.Children)
//    {
//        tabsforchildren(item, indentation + 1);
//    }
//}

//PdfTextService textService = new PdfTextService();

//Console.WriteLine();
//Console.Write("Enter chapter ID: ");
//// Read the chapter ID as an integer from the console
//// int chapterId = ...;

//// Get the text of that chapter using textService and store it in a string
//// string text = ...;

//// Write this text to a file "output.txt"

using Courseify.DataAccessLayer;

SessionDatabaseService service = new();
await service.GenerateSession(null!);