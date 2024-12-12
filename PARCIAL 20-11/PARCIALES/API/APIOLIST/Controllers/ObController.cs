using APIOLIST;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;

namespace OBJcON.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddObjController : ControllerBase
    {
        private static List<Person> _personas = new List<Person>();


        [HttpPost]
        public IActionResult AddPersona([FromBody] Person persona)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("No se pudo agregar a la persona");
            }

            _personas.Add(persona);
            return Ok("Persona agregada correctamente");
        }

        [HttpGet("all")]
        public IActionResult GetPersonas()
        {
            return Ok(_personas);
        }

        [HttpGet("searchByName/{name}")]
        public IActionResult GetPersonaByName(string name)
        {
            var persona = _personas.FirstOrDefault(p => p.nombre == name);
            if (persona == null)
            {
                return NotFound("No se encontró la persona");
            }
            return Ok(persona);
        }

        [HttpDelete("deleteByName/{name}")]
        public IActionResult DeletePersona(string name)
        {
            var persona = _personas.FirstOrDefault(p => p.nombre == name);
            if (persona == null)
            {
                return NotFound("No se encontró la persona");
            }
            _personas.Remove(persona);
            return Ok("Persona eliminada correctamente");
        }
    }
}
