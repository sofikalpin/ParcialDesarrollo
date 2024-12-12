using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace ComercioAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComercioController : ControllerBase
    {
        private readonly Servicio _productoServicio;

        public ComercioController()
        {
            _productoServicio = new Servicio();
        }

        [HttpGet]
        public IActionResult GetProductos()
        {
            try
            {
                var productos = _productoServicio.GetProductos();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al obtener los productos: {ex.Message}");
            }
        }

        [HttpPost]
        public IActionResult CreateProducto([FromBody] Modelos.Comercio producto)
        {
            try
            {
                _productoServicio.AddProducto(producto);
                return Ok("Producto agregado exitosamente");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al agregar el producto: {ex.Message}");
            }
        }

        [HttpPut]
        public IActionResult UpdateProducto([FromBody] Modelos.Comercio producto)
        {
            try
            {
                _productoServicio.PutProducto(producto);
                return Ok("Producto actualizado exitosamente");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al actualizar el producto: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProducto(int id)
        {
            try
            {
                _productoServicio.DeleteProducto(id);
                return Ok("Producto eliminado exitosamente");
            }
            catch (Exception ex)
            {
                return NotFound($"Error al eliminar el producto: {ex.Message}");
            }
        }
    }
}
