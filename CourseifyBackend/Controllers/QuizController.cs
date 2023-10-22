using Courseify.DataAccessLayer;
using Courseify.DataAccessLayer.Exceptions;
using Courseify.OpenAI.Quiz;
using Courseify.PdfMan.Text;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseifyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly ISessionDatabaseService service;
        private readonly IQuizOpenAiService openai;

        public QuizController(ISessionDatabaseService service, IQuizOpenAiService openai)
        {
            this.service = service;
            this.openai = openai;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuiz(string sessionId, Guid chapterId)
        {
            var session = await service.GetSession(sessionId) ?? throw new InvalidSessionIdException(sessionId);
            string text = session.FindNodeById(chapterId)?.Text! ?? "";
            var quizzes = await openai.GetQuizzes(text);
            return Ok(quizzes);
        }
    }
}
