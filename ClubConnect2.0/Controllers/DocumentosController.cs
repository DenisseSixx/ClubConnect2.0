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
        public async Task<ActionResult<Expedientetercero>> CreateAppautorizaciond([FromBody] Expedientetercero expedientetercero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(expedientetercero);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(expedientetercero), new { id = expedientetercero.CodTercero }, expedientetercero);
            }
            return BadRequest(ModelState);
        }
    }
}
