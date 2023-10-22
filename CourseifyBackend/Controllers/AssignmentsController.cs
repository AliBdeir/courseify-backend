using Courseify.DataAccessLayer;
using Courseify.DataAccessLayer.Exceptions;
using Courseify.OpenAI.Assignments;
using Microsoft.AspNetCore.Mvc;
using Rystem.OpenAi;

namespace CourseifyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        private readonly ISessionDatabaseService service;
        private readonly IAssignmentOpenAiService assignmentOpenAiService;

        public AssignmentsController(ISessionDatabaseService service, IAssignmentOpenAiService assignmentOpenAiService)
        {
            this.service = service;
            this.assignmentOpenAiService = assignmentOpenAiService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAssignment(string sessionId, Guid chapterId)
        {
            var session = await service.GetSession(sessionId) ?? throw new InvalidSessionIdException(sessionId);
            string text = session.FindNodeById(chapterId)?.Text! ?? "";
            string assignment = await assignmentOpenAiService.GetAssignment(text);
            return Ok(assignment);
        }

        [HttpPost]
        public async Task<IActionResult> GetAssignment([FromBody] RateAssignmentRequest req)
        {
            string grading = await assignmentOpenAiService.RateAssignment(req.UserInput, req.Assignment);
            return Ok(grading);
        }


        public class RateAssignmentRequest
        {
            public string UserInput { get; set; }
            public string Assignment { get; set; }
        }


    }
}
