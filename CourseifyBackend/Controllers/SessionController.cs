using Courseify.DataAccessLayer;
using Courseify.DataAccessLayer.Exceptions;
using Courseify.PdfMan.Bookmarks.Data;
using CourseifyBackend.Data.SessionOverview;
using Firebase.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace CourseifyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly ISessionDatabaseService database;

        public SessionController(ISessionDatabaseService database)
        {
            this.database = database;
        }

        [HttpGet]
        [Route("{sessionId}/Overview")]
        public async Task<IActionResult> GetSessionOverview(string sessionId)
        {
            try
            {
                BookmarkNode value = await database.GetSession(sessionId);
                List<SessionOverview> frontendValue = new();
                foreach (var child in value.Children)
                {
                    string title = child.Title.ToLower().Trim();
                    if (Regex.IsMatch(title, @"^\d") || title.StartsWith("ch"))
                    {
                        frontendValue.Add(new()
                        {
                            Id = child.Id,
                            Title = child.Title,
                            PageNumber = child.PageNumber,
                        });
                    }
                }
                return base.Ok(frontendValue);
            }
            catch (InvalidSessionIdException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
