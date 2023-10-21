// See https://aka.ms/new-console-template for more information
using Courseify.PdfMan.Bookmarks;
// Input PDF 
Console.WriteLine("Hello, World!");
PdfBookmarkService bookmarkService = new PdfBookmarkService();
String PdfFilePath = "C:\\Users\\benda\\Downloads\\PHYSICS 150 BOOK.pdf";
bookmarkService.GetBookmarksFromPdf(PdfFilePath); 