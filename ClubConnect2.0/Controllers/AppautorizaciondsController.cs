using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace ClubConnect2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppautorizaciondsController : ControllerBase
    {
        private readonly CuotasV100Context _context;

        public AppautorizaciondsController(CuotasV100Context context)
        {
            _context = context;
        }

        // GET: api/Appautorizacionds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appautorizaciond>>> GetAppautorizacionds()
        {
            return await _context.Appautorizacionds.ToListAsync();
        }

        // GET: api/Appautorizacionds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Appautorizaciond>> GetAppautorizaciond(string id)
        {
            var appautorizaciond = await _context.Appautorizacionds.FirstOrDefaultAsync(m => m.CodTercero == id);

            if (appautorizaciond == null)
            {
                return NotFound();
            }

            return appautorizaciond;
        }

        // POST: api/Appautorizacionds/Crear
        [HttpPost("Crear")]
        public async Task<ActionResult<Appautorizaciond>> CreateAppautorizaciond([FromBody] Appautorizaciond appautorizaciond)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appautorizaciond);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetAppautorizaciond), new { id = appautorizaciond.CodTercero }, appautorizaciond);
            }
            return BadRequest(ModelState);
        }

        // PUT: api/Appautorizacionds/Editar/5
        [HttpPut("Editar/{id}")]
        public async Task<IActionResult> UpdateAppautorizaciond(string id, [FromBody] Appautorizaciond appautorizaciond)
        {
            if (id != appautorizaciond.CodTercero)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appautorizaciond);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppautorizaciondExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        // DELETE: api/Appautorizacionds/Eliminar/5
        [HttpDelete("Eliminar/{id}")]
        public async Task<ActionResult<Appautorizaciond>> DeleteAppautorizaciond(string id)
        {
            var appautorizaciond = await _context.Appautorizacionds.FirstOrDefaultAsync(m => m.CodTercero == id);
            if (appautorizaciond == null)
            {
                return NotFound();
            }

            _context.Appautorizacionds.Remove(appautorizaciond);
            await _context.SaveChangesAsync();

            return appautorizaciond;
        }

        private bool AppautorizaciondExists(string id)
        {
            return _context.Appautorizacionds.Any(e => e.CodTercero == id);
        }
    }
}
