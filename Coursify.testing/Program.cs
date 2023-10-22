// See https://aka.ms/new-console-template for more information
// Input PDF 
using Courseify.PdfMan.Bookmarks;
using Courseify.PdfMan.Bookmarks.Data;
using Courseify.PdfMan.Text;
using iText.Kernel.Pdf;
using iText.StyledXmlParser.Jsoup.Nodes;
using System.Diagnostics;
using System.Text;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

IPdfTextService textService = new PdfTextService();
PdfBookmarkService bookmarkService = new PdfBookmarkService(textService);
string PdfFilePath = "C:\\Users\\MSE\\Downloads\\PHYSICS 150 BOOK.pdf";
using PdfReader reader = new PdfReader(PdfFilePath);
PdfDocument doc = new(reader);
var bookmarks = bookmarkService.GetBookmarksFromPdf(doc, true);
tabsforchildren(bookmarks);
// Go trhoigh the list of nodes using a for loop 
void tabsforchildren(BookmarkNode Node, int indentation = 0)
{
    Console.WriteLine(new string('\t', indentation) + $"{Node.Title} ({Node.Id})");

    foreach (var item in Node.Children)
    {
        tabsforchildren(item, indentation + 1);
    }
}


Console.WriteLine();
Console.Write("Enter chapter ID: ");
// Read the chapter ID as an integer from the console
// int chapterId = ...;

int chapterId;
while (!int.TryParse(Console.ReadLine(), out chapterId))
{
    Console.WriteLine("Invalid Try again");
}


// Get the text of that chapter using textService and store it in a string
// string text = ...;

var node =
     ((BookmarkNode)bookmarks.FindNodeById(chapterId)!);
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
// Write this text to a file "output.txt"
File.WriteAllText("output.txt", text.ToString());
Console.WriteLine("Text has been written to output.txt");