using DataManagment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClubConnect2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentosController : ControllerBase
    {
        private readonly CuotasV100Context _context;

        public DocumentosController(CuotasV100Context context)
        {
            _context = context;
        }
        [HttpGet("ObtenerTiposDocumentos")]
        public async Task<IActionResult> ObtenerUsuarios()
        {
            return Ok(await _context.Etipodocumentos.ToListAsync());
        }

        [HttpPost("Crear")]
        public async Task<ActionResult> CrearDocumento(ExpedienteIntermediaria expedienteIntermediaria)
        {
            try
            {
                if (expedienteIntermediaria == null)
                {
                    return BadRequest("El objeto expedienteIntermediaria es nulo.");
                }

                // Establecer la fecha actual
                expedienteIntermediaria.Fecha = DateTime.Now;
                if (expedienteIntermediaria.CodArchivo == null)
                {
                    return BadRequest("La propiedad CodArchivo del objeto expedienteIntermediaria es null.");
                }

                _context.Add(expedienteIntermediaria);
                await _context.SaveChangesAsync();

                return Ok("ExpedienteIntermediaria creado exitosamente.");
            }
            catch (Exception ex)
            {
                var innerExceptionMessage = (ex.InnerException != null) ? ex.InnerException.Message : "";
                return BadRequest($"Error al crear el expedienteIntermediaria. Detalles: {ex.Message}. Excepción interna: {innerExceptionMessage}");
            }
        }

    }
}
