using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AUCKPOLLWEB.Areas.Identity.Data;
using AUCKPOLLWEB.Models;

namespace AUCKPOLLWEB.Controllers
{
    public class estuaryQualitiesController : Controller
    {
        private readonly AUCKPOLLWEBContext _context;

        public estuaryQualitiesController(AUCKPOLLWEBContext context)
        {
            _context = context;
        }

        // GET: estuaryQualities
        public async Task<IActionResult> Index()
        {
              return _context.estuaryQuality != null ? 
                          View(await _context.estuaryQuality.ToListAsync()) :
                          Problem("Entity set 'AUCKPOLLWEBContext.estuaryQuality'  is null.");
        }

        // GET: estuaryQualities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.estuaryQuality == null)
            {
                return NotFound();
            }

            var estuaryQuality = await _context.estuaryQuality
                .FirstOrDefaultAsync(m => m.sampleID == id);
            if (estuaryQuality == null)
            {
                return NotFound();
            }

            return View(estuaryQuality);
        }

        // GET: estuaryQualities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: estuaryQualities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("sampleID,collection_date,indicator,value")] estuaryQuality estuaryQuality)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estuaryQuality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estuaryQuality);
        }

        // GET: estuaryQualities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.estuaryQuality == null)
            {
                return NotFound();
            }

            var estuaryQuality = await _context.estuaryQuality.FindAsync(id);
            if (estuaryQuality == null)
            {
                return NotFound();
            }
            return View(estuaryQuality);
        }

        // POST: estuaryQualities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("sampleID,collection_date,indicator,value")] estuaryQuality estuaryQuality)
        {
            if (id != estuaryQuality.sampleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estuaryQuality);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!estuaryQualityExists(estuaryQuality.sampleID))
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
            return View(estuaryQuality);
        }

        // GET: estuaryQualities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.estuaryQuality == null)
            {
                return NotFound();
            }

            var estuaryQuality = await _context.estuaryQuality
                .FirstOrDefaultAsync(m => m.sampleID == id);
            if (estuaryQuality == null)
            {
                return NotFound();
            }

            return View(estuaryQuality);
        }

        // POST: estuaryQualities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.estuaryQuality == null)
            {
                return Problem("Entity set 'AUCKPOLLWEBContext.estuaryQuality'  is null.");
            }
            var estuaryQuality = await _context.estuaryQuality.FindAsync(id);
            if (estuaryQuality != null)
            {
                _context.estuaryQuality.Remove(estuaryQuality);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool estuaryQualityExists(int id)
        {
          return (_context.estuaryQuality?.Any(e => e.sampleID == id)).GetValueOrDefault();
        }
    }
}
