using Microsoft.AspNetCore.Mvc;
using SERVICE;

namespace MultiplicacionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiController : ControllerBase
    {
        private readonly IServicio _servicio;

        public MultiController(IServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet("multiplicar")]
        public IActionResult Multiplicar([FromQuery] double num1, [FromQuery] double num2)
        {
           
            double resultado = _servicio.multi(num1, num2);
            return Ok(resultado);
        }
    }
}
