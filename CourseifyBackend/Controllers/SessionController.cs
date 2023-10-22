using Courseify.DataAccessLayer;
using Courseify.DataAccessLayer.Exceptions;
using Firebase.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                return Ok(await database.GetSessionNoText(sessionId));
            }
            catch (InvalidSessionIdException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
