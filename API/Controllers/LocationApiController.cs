using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    public class LocationApiController : ControllerBase
    {
        private readonly string ipStackApiKey = "ec91a5cbba85489e17b761ff98eccf5b";

        [HttpGet("Location")]
        public async Task<IActionResult> GetLocation(string ipAddress)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var apiUrl = $"http://api.ipstack.com/{ipAddress}?access_key={ipStackApiKey}";
                    var response = await client.GetStringAsync(apiUrl);

                    return Content(response, "application/json");
                }
                catch (HttpRequestException)
                {
                    return BadRequest("Unable to retrieve data.");
                }
            }
        }
    }
}
