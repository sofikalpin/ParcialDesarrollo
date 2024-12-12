using Microsoft.AspNetCore.Mvc;

namespace APILista.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListPersona : ControllerBase
    {
        private static List<string> _nombre = new List<string>
        {
            "Juan", "Maria"
        };

        [HttpGet(Name = "GetLista")]
        public ActionResult<IEnumerable<string>> ObtenerNombres()
        {
            return Ok(_nombre);
        }

        [HttpPost]
        public ActionResult AgregarNombre([FromBody] Persona request)
        {
            if (string.IsNullOrWhiteSpace(request?.Nombre))
            {
                return BadRequest(new { mensaje = "Debe proporcionar un nombre válido" });
            }

            _nombre.Add(request.Nombre);

            return CreatedAtAction(
                nameof(ObtenerNombres),
                new { nombre = request.Nombre },
                new
                {
                    mensaje = "Nombre agregado exitosamente",
                    nombres = _nombre
                }
            );
        }
    }
}
