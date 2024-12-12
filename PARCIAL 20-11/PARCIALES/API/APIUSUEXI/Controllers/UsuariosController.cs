using Microsoft.AspNetCore.Mvc;
using ServicioUsuario;

namespace APIUSUEXI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IServicio _usuarioService;

        public UsuariosController(IServicio usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("existe")]
        public IActionResult ExisteUsuario([FromQuery] string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                return BadRequest("El nombre es requerido.");
            }

            bool existe = _usuarioService.Existe(nombre);
            return Ok(new { UsuarioExiste = existe });
        }
    }

}
