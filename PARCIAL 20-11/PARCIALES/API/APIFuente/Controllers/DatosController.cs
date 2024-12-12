using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;

namespace APIFuente.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DatosController : ControllerBase
    {
        private static string filePath = "datos.xlsx";

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null) return BadRequest();

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return Ok("Archivo cargado");
        }

        [HttpGet]
        public IActionResult Get([FromQuery] string ciudad, [FromQuery] int? edadMinima)
        {
            try
            {
                if (!System.IO.File.Exists(filePath))
                    return BadRequest("Primero debe cargar un archivo Excel");

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    var listaDatos = new List<Datos>();

                    int rows = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rows; row++)
                    {
                        var dato = new Datos
                        {
                            ID = int.Parse(worksheet.Cells[row, 1].Text),
                            Nombre = worksheet.Cells[row, 2].Text,
                            Edad = int.Parse(worksheet.Cells[row, 3].Text),
                            Ciudad = worksheet.Cells[row, 4].Text
                        };

                        // Aplicar filtros
                        if ((!string.IsNullOrEmpty(ciudad) &&
                             !dato.Ciudad.ToLower().Contains(ciudad.ToLower())))
                            continue;

                        if (edadMinima.HasValue && dato.Edad < edadMinima.Value)
                            continue;

                        listaDatos.Add(dato);
                    }

                    return Ok(listaDatos);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al procesar el archivo: {ex.Message}");
            }
        }

        [HttpGet("ciudades")]
        public IActionResult GetCiudades()
        {
            try
            {
                if (!System.IO.File.Exists(filePath))
                    return BadRequest("Primero debe cargar un archivo Excel");

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    var ciudades = new HashSet<string>();

                    for (int row = 2; row <= worksheet.Dimension.Rows; row++)
                    {
                        ciudades.Add(worksheet.Cells[row, 4].Text);
                    }

                    return Ok(ciudades);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al procesar el archivo: {ex.Message}");
            }
        }
    }
}