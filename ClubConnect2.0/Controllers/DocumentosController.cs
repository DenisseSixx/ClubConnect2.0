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
        public async Task<ActionResult<ExpedienteIntermediaria>> CreateExpedienteIntermediaria([FromBody] ExpedienteIntermediaria expedienteIntermediaria)
        {
            if (expedienteIntermediaria == null)
            {
                return BadRequest("El objeto de expedienteIntermediaria es nulo.");
            }

            if (ModelState.IsValid)
            {
                _context.Add(expedienteIntermediaria);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(CreateExpedienteIntermediaria), new { id = expedienteIntermediaria.CodArchivo }, expedienteIntermediaria);
            }

            return BadRequest(ModelState);
        }

    }
    }
