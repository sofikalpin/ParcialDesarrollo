using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace MultiplesPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Multicontroller : ControllerBase
    {
        private readonly HttpClient _httpClient = new HttpClient();

        [HttpGet(Name = "getmulti")]
        public async Task<IActionResult> GetData()
        {
            string api1 = "https://randomuser.me/api";
            string api2 = "https://api.chucknorris.io/jokes/random";

            var resp1 = await _httpClient.GetStringAsync(api1);
            var resp2 = await _httpClient.GetStringAsync(api2);

            var json1 = JObject.Parse(resp1);
            var json2 = JObject.Parse(resp2);

            var randomUser = json1["name"]?.ToString();
            var joke = json2["value"]?.ToString();

            return Ok(new { randomUser, joke });

        }
    }
}
