using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace APICDATA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DATA : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public DATA()
        {
            _httpClient = new HttpClient();
        }

        [HttpGet(Name = "CANTIDAD")]
        public async Task<IActionResult> GetCantuser(int cantidad)
        {
            string api = $"https://randomuser.me/api/?results={cantidad}";
            var response = await _httpClient.GetAsync(api);

            if (!response.IsSuccessStatusCode)
            {
                return BadRequest("Failed to fetch user data");
            }

            var jsonString = await response.Content.ReadAsStringAsync();
            var jsonObject = JObject.Parse(jsonString);

            var nombres = new List<string>();

            foreach (var user in jsonObject["results"])
            {
                nombres.Add(user["name"]["first"].ToString());
            }

            return Ok(nombres);
        }
    }
}