using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    public class ListingApiController : ControllerBase
    {
        private readonly string externalApiUrl = "https://jayridechallengeapi.azurewebsites.net/api/QuoteRequest";

        [HttpGet("Listings")]
        public async Task<IActionResult> GetListings(int passengerCount)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(externalApiUrl);
                    var vehicleRoute = JsonSerializer.Deserialize<VehicleRoute>(response);
                    var filteredListings = vehicleRoute.listings.FindAll(x => x.vehicleType.maxPassengers >= passengerCount);

                    foreach (var listing in filteredListings)
                    {
                        listing.totalPrice = listing.pricePerPassenger * passengerCount;
                    }

                    return Ok(filteredListings.OrderBy(x => x.totalPrice));
                }
                catch (HttpRequestException)
                {
                    return BadRequest("Unable to retrieve data.");
                }
            }
        }
    }
}
