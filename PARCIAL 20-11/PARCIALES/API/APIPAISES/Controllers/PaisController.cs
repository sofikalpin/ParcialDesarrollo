using Microsoft.AspNetCore.Mvc;
namespace APIPAISES.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PaisController : ControllerBase
    {
        private static readonly List<Paises> _pais = new()
        {
            new Paises { nombre = "Estados Unidos" },
            new Paises { nombre = "Argentina" }
        };

        [HttpGet(Name = "GetLista")]
        public ActionResult<IEnumerable<Paises>> GetPaises()
        {
            return Ok(_pais);
        }
    }

   
}