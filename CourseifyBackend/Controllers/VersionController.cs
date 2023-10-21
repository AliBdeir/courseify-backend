using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseifyBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(System.Reflection.Assembly.GetEntryAssembly()?.GetName().Version?.ToString() ?? "No version found");
        }
    }
}
