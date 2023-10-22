using Courseify.PdfMan.Bookmarks;
using iText.Kernel.Pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.Xml;
using static Courseify.PdfMan.Bookmarks.IPdfBookmarkService;

namespace CourseifyBackend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PdfController : ControllerBase
    {

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

            // Save or process the file. For this example, I'll just save the file to a directory named "Uploads" in the root of the project.
            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "Uploads");
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            var filePath = Path.Combine(uploadsFolder, file.FileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            PdfBookmarkService service = new();
            using var reader = new PdfReader(file.OpenReadStream());
            var document = new PdfDocument(reader);
            BookmarkNode bookmarks = service.GetBookmarksFromPdf(document);
            
            return Ok(bookmarks);            
        }

    }
}
