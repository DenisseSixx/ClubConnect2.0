using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace ClubConnect2._0.Controllers
{
    public class AppautorizaciondsController : Controller
    {
        private readonly CuotasV100Context _context;

        public AppautorizaciondsController(CuotasV100Context context)
        {
            _context = context;
        }

        // GET: Appautorizacionds
        public async Task<IActionResult> Index()
        {
            return View(await _context.Appautorizacionds.ToListAsync());
        }

        // GET: Appautorizacionds/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appautorizaciond = await _context.Appautorizacionds
                .FirstOrDefaultAsync(m => m.CodTercero == id);
            if (appautorizaciond == null)
            {
                return NotFound();
            }

            return View(appautorizaciond);
        }

        // GET: Appautorizacionds/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Appautorizacionds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Crear")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodTercero,CodDependiente,CodAutorizacion")] Appautorizaciond appautorizaciond)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appautorizaciond);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(appautorizaciond);
        }

        // GET: Appautorizacionds/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appautorizaciond = await _context.Appautorizacionds.FindAsync(id);
            if (appautorizaciond == null)
            {
                return NotFound();
            }
            return View(appautorizaciond);
        }

        // POST: Appautorizacionds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("editar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CodTercero,CodDependiente,CodAutorizacion")] Appautorizaciond appautorizaciond)
        {
            if (id != appautorizaciond.CodTercero)
            {
                return NotFound();
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
                    if (!AppautorizaciondExists(appautorizaciond.CodTercero))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(appautorizaciond);
        }

        // GET: Appautorizacionds/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appautorizaciond = await _context.Appautorizacionds
                .FirstOrDefaultAsync(m => m.CodTercero == id);
            if (appautorizaciond == null)
            {
                return NotFound();
            }

            return View(appautorizaciond);
        }

        // POST: Appautorizacionds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var appautorizaciond = await _context.Appautorizacionds.FindAsync(id);
            if (appautorizaciond != null)
            {
                _context.Appautorizacionds.Remove(appautorizaciond);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppautorizaciondExists(string id)
        {
            return _context.Appautorizacionds.Any(e => e.CodTercero == id);
        }
    }
}
