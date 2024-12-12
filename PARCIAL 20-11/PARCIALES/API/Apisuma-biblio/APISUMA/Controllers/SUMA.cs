using Microsoft.AspNetCore.Mvc;
using BiblioAPI;

namespace APISUMA.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        [HttpGet(Name = "Palabras")]
        public IActionResult Palabra(string pa1, string pa2)
        {
            return Ok(Opera.Palabra(pa1, pa2));
        }

    }
}