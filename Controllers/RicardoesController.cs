using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Progra_4_Progreso_1.Data;
using Progra_4_Progreso_1.Models;

namespace Progra_4_Progreso_1.Controllers
{
    public class RicardoesController : Controller
    {
        private readonly Progra_4_Progreso_1Context _context;

        public RicardoesController(Progra_4_Progreso_1Context context)
        {
            _context = context;
        }

        // GET: Ricardoes
        public async Task<IActionResult> Index()
        {
              return _context.Ricardo != null ? 
                          View(await _context.Ricardo.ToListAsync()) :
                          Problem("Entity set 'Progra_4_Progreso_1Context.Ricardo'  is null.");
        }

        // GET: Ricardoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Ricardo == null)
            {
                return NotFound();
            }

            var ricardo = await _context.Ricardo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ricardo == null)
            {
                return NotFound();
            }

            return View(ricardo);
        }

        // GET: Ricardoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ricardoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Calificacion,Estado,EstadoFecha,Idcarrera")] Ricardo ricardo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ricardo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ricardo);
        }

        // GET: Ricardoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Ricardo == null)
            {
                return NotFound();
            }

            var ricardo = await _context.Ricardo.FindAsync(id);
            if (ricardo == null)
            {
                return NotFound();
            }
            return View(ricardo);
        }

        // POST: Ricardoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Calificacion,Estado,EstadoFecha,Idcarrera")] Ricardo ricardo)
        {
            if (id != ricardo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ricardo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RicardoExists(ricardo.Id))
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
            return View(ricardo);
        }

        // GET: Ricardoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Ricardo == null)
            {
                return NotFound();
            }

            var ricardo = await _context.Ricardo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ricardo == null)
            {
                return NotFound();
            }

            return View(ricardo);
        }

        // POST: Ricardoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Ricardo == null)
            {
                return Problem("Entity set 'Progra_4_Progreso_1Context.Ricardo'  is null.");
            }
            var ricardo = await _context.Ricardo.FindAsync(id);
            if (ricardo != null)
            {
                _context.Ricardo.Remove(ricardo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RicardoExists(int id)
        {
          return (_context.Ricardo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
