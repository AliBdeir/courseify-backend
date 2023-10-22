using Courseify.DataAccessLayer.Exceptions;
using Courseify.DataAccessLayer;
using Courseify.OpenAI.Quiz;
using Microsoft.AspNetCore.Mvc;
using Courseify.OpenAI.Flashcards;

namespace CourseifyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashcardsController : ControllerBase
    {
        private readonly ISessionDatabaseService service;
        private readonly IFlashcardsOpenAiService openai;

        public FlashcardsController(ISessionDatabaseService service, IFlashcardsOpenAiService openai)
        {
            this.service = service;
            this.openai = openai;
        }

        [HttpGet]
        public async Task<IActionResult> GetFlashcards(string sessionId, Guid chapterId)
        {
            var session = await service.GetSession(sessionId) ?? throw new InvalidSessionIdException(sessionId);
            string text = session.FindNodeById(chapterId)?.Text! ?? "";
            var quizzes = await openai.GetFlashcards(text);
            return Ok(quizzes);
        }

    }
}
