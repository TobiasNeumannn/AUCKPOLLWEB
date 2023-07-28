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
    public class gWaterQualitiesController : Controller
    {
        private readonly AUCKPOLLWEBContext _context;

        public gWaterQualitiesController(AUCKPOLLWEBContext context)
        {
            _context = context;
        }

        // GET: gWaterQualities
        public async Task<IActionResult> Index()
        {
              return _context.gWaterQuality != null ? 
                          View(await _context.gWaterQuality.ToListAsync()) :
                          Problem("Entity set 'AUCKPOLLWEBContext.gWaterQuality'  is null.");
        }

        // GET: gWaterQualities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.gWaterQuality == null)
            {
                return NotFound();
            }

            var gWaterQuality = await _context.gWaterQuality
                .FirstOrDefaultAsync(m => m.sampleID == id);
            if (gWaterQuality == null)
            {
                return NotFound();
            }

            return View(gWaterQuality);
        }

        // GET: gWaterQualities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: gWaterQualities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("sampleID,ID,collection_date,indicator,value,unit")] gWaterQuality gWaterQuality)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gWaterQuality);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gWaterQuality);
        }

        // GET: gWaterQualities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.gWaterQuality == null)
            {
                return NotFound();
            }

            var gWaterQuality = await _context.gWaterQuality.FindAsync(id);
            if (gWaterQuality == null)
            {
                return NotFound();
            }
            return View(gWaterQuality);
        }

        // POST: gWaterQualities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("sampleID,ID,collection_date,indicator,value,unit")] gWaterQuality gWaterQuality)
        {
            if (id != gWaterQuality.sampleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gWaterQuality);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!gWaterQualityExists(gWaterQuality.sampleID))
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
            return View(gWaterQuality);
        }

        // GET: gWaterQualities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.gWaterQuality == null)
            {
                return NotFound();
            }

            var gWaterQuality = await _context.gWaterQuality
                .FirstOrDefaultAsync(m => m.sampleID == id);
            if (gWaterQuality == null)
            {
                return NotFound();
            }

            return View(gWaterQuality);
        }

        // POST: gWaterQualities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.gWaterQuality == null)
            {
                return Problem("Entity set 'AUCKPOLLWEBContext.gWaterQuality'  is null.");
            }
            var gWaterQuality = await _context.gWaterQuality.FindAsync(id);
            if (gWaterQuality != null)
            {
                _context.gWaterQuality.Remove(gWaterQuality);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool gWaterQualityExists(int id)
        {
          return (_context.gWaterQuality?.Any(e => e.sampleID == id)).GetValueOrDefault();
        }
    }
}
