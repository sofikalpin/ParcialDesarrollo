using Microsoft.AspNetCore.Mvc;
using StringServicio;

namespace APILongitudString.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LongitudController : ControllerBase
    {
        private readonly IStringServicio _stringServicio;

        public LongitudController(IStringServicio stringServicio)
        {
            _stringServicio = stringServicio;
        }

        [HttpGet(Name = "GetString")]
        public IActionResult obtenerLongitud([FromQuery] string input)
        {
            // Validaci�n de entrada
            if (string.IsNullOrEmpty(input))
            {
                return BadRequest("No se ha introducido ning�n texto");
            }

            // Obtener la longitud usando el servicio inyectado
            int longitud = _stringServicio.obtenerLongitud(input);

            // Devolver la longitud
            return Ok(longitud);
        }
    }
}