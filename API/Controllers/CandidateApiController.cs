using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class CandidateApiController : ControllerBase
    {
        [HttpGet("candidate")]
        public IActionResult GetCandidate()
        {
            var candidate = new
            {
                name = "test",
                phone = "test"
            };

            return Ok(candidate);
        }
    }
}
