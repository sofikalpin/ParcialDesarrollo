using Microsoft.AspNetCore.Mvc;

namespace APIREST.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult<string> Get()
        {
            return "Hola, estoy devolviendo un get en una API Simple";
           
        }
    }
}
