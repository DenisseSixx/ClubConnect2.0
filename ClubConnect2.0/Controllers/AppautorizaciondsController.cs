using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataManagment.Models;
using Rules;

namespace ClubConnect2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppautorizaciondsController : ControllerBase
    {
        private readonly CuotasV100Context _context;
        private readonly AutorizacionDepen _autorizacionDepen;
        public AppautorizaciondsController(CuotasV100Context context)
        {
            _context = context;
            _autorizacionDepen = new AutorizacionDepen();

        }

        // GET: api/Appautorizacionds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Appautorizaciond>>> GetAppautorizacionds()
        {
            return await _context.Appautorizacionds.ToListAsync();
        }

        // GET: api/Appautorizacionds/5
        [HttpGet("ObtenerDepenTer/{id}")]
        public async Task<ActionResult<IEnumerable<Appautorizaciond>>> GetAppautorizaciond(string id)
        {
            var appautorizaciondList = await _context.Appautorizacionds
                .Where(m => m.CodTercero == id)
                .ToListAsync();

            if (!appautorizaciondList.Any())
            {
                return NotFound();
            }

            return appautorizaciondList;
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
        [HttpGet("ObtenerPorCodTercero/{codTercero}")]
        public async Task<ActionResult<IEnumerable<Appautorizaciond>>> ObtenerPorCodTercero(string codTercero)
        {
            return await _context.Appautorizacionds.Where(a => a.CodTercero == codTercero).ToListAsync();
        }
        // PUT: api/Appautorizacionds/Editar/5
        [HttpPut("Editar/{CodTercero}/{CodDependiente}")]
        public async Task<IActionResult> UpdateAppautorizaciond(string CodTercero, decimal CodDependiente, [FromBody] Appautorizaciond appautorizaciond)
        {
            if (CodTercero != appautorizaciond.CodTercero)
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
                    if (!AppautorizaciondExists(CodTercero))
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
        [HttpPut("EditarEstado/{CodTercero}/{CodDependiente}")]
        public async Task<IActionResult> UpdateAppautorizaciond(string CodTercero, decimal CodDependiente, [FromBody] bool codAutorizacion)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var existingAppautorizaciond = await _context.Appautorizacionds.FirstOrDefaultAsync(x => x.CodTercero == CodTercero && x.CodDependiente == CodDependiente);
                    if (existingAppautorizaciond == null)
                    {
                        return NotFound();
                    }

                    existingAppautorizaciond.CodAutorizacion = codAutorizacion; // Actualiza el estado con el valor proporcionado

                    _context.Entry(existingAppautorizaciond).State = EntityState.Modified;
                    await _context.SaveChangesAsync();
                    return NoContent();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppautorizaciondExists(CodTercero))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return BadRequest(ModelState);
        }


        // DELETE: api/Appautorizacionds/Eliminar/5
        [HttpDelete("Eliminar/{id}")]
        public async Task<ActionResult<Appautorizaciond>> DeleteAppautorizaciond(string id, int iddep)
        {
            var appautorizaciond = await _context.Appautorizacionds.FirstOrDefaultAsync(m => m.CodTercero == id && m.CodDependiente == iddep);
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
            return _context.Appautorizacionds.Any(e => e.CodTercero == id );
        }

        [HttpGet("VerificarAutorizacion/{codUsuario}")]
        public ActionResult<bool> VerifyAutorizacion(string codUsuario)
        {
            // Llama al método VerifyCodAutorizacion de AutorizacionDepen
            bool autorizado = _autorizacionDepen.VerifyCodAutorizacion(codUsuario);
            return autorizado;
        }

        [HttpGet("ObtenerCodDependiente/{codUsuario}")]
        public ActionResult<int?> GetCodDependiente(string codUsuario)
        {
            try
            {
                var autorizacionDepen = new AutorizacionDepen(); // Instancia de la clase AutorizacionDepen
                var codDependiente = autorizacionDepen.ObtenerCodDependiente(codUsuario);

                if (codDependiente != null)
                {
                    return codDependiente;
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error obteniendo el CodDependiente: " + ex.Message);
                return StatusCode(500, "Error interno del servidor");
            }
        }
    }
}
