using APIUSUNA;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PersonasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        
        private static readonly List<USU> usuarios = new List<USU>();

        [HttpPost("guardar")]
        public IActionResult Guardar([FromBody] USU nuevoUsuario)
        {
          
            usuarios.Add(nuevoUsuario);

            
            System.Console.WriteLine(nuevoUsuario);

           
            return CreatedAtAction(nameof(Guardar), new { mensaje = "Persona guardada", persona = nuevoUsuario });
        }
    }
}
