using Courseify.DataAccessLayer;
using Courseify.PdfMan.Bookmarks;
using Courseify.PdfMan.Bookmarks.Data;
using iText.Kernel.Pdf;
using Microsoft.AspNetCore.Mvc;

namespace CourseifyBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {
        private readonly IPdfBookmarkService bookmarkService;
        private readonly ISessionDatabaseService database;

        public PdfController(IPdfBookmarkService bookmarkService, ISessionDatabaseService database)
        {
            this.bookmarkService = bookmarkService;
            this.database = database;
        }

        [HttpPost("Upload")]
        [RequestSizeLimit(300_000_000)] // Set the limit to 300MB for this endpoint.
        public async Task<IActionResult> UploadPDF(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file received");
            }

            if (Path.GetExtension(file.FileName).ToLower() != ".pdf")
            {
                return BadRequest("Invalid file type. Only PDF files are allowed.");
            }            
            using var reader = new PdfReader(file.OpenReadStream());
            var document = new PdfDocument(reader);
            BookmarkNode bookmarks = bookmarkService.GetBookmarksFromPdf(document, true);
            string sessionId = await database.GenerateSession(bookmarks);
            return Ok(sessionId);            
        }

    }
}
