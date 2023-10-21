namespace Courseify.PdfMan
{
    public interface IPdfBookmarkService
    {
        Dictionary<string, int> GetBookmarksFromPdf(string inputFilePath);
    }
}