using Microsoft.AspNetCore.Mvc;

namespace APIConcatenacion.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Conca : ControllerBase
    {
       

        [HttpPost(Name ="Concatenar")]
        public IActionResult ConcatenarPalabra([FromBody] palabras palabra)
        {
            if(palabra == null || string.IsNullOrEmpty(palabra.Palabra1) || string.IsNullOrEmpty(palabra.Palabra2))
            {
                return BadRequest(new {error = "Ingrese 2 palabras"});
            }
            string resultado = palabra.Palabra1 + palabra.Palabra2;
            return Ok(new {concatenacion  = resultado});    
        }
    }
}
