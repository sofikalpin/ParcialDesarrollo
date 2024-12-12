using Biblio;
using Microsoft.AspNetCore.Mvc;

namespace APIDIVISION.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisionController : ControllerBase
    {
        private readonly IServicio _servicio;

        public DivisionController(IServicio servicio)
        {
            _servicio = servicio;
        }

        [HttpGet(Name = "Division")]
        public IActionResult obtenerdiv([FromQuery] double num1, [FromQuery] double num2)
        {
            if (num2 == 0)
            {
                return BadRequest("No se puede dividir entre cero.");
            }

            double resultado = _servicio.obtenerdiv(num1, num2);
            return Ok(resultado);
        }
    }
}
