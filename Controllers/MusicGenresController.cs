using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CSCI213___Assignment_5;
using CSCI213___Assignment_5.Data;

namespace CSCI213___Assignment_5.Controllers
{
    public class MusicGenresController : Controller
    {
        private readonly CSCI213___Assignment_5Context _context;

        public MusicGenresController(CSCI213___Assignment_5Context context)
        {
            _context = context;
        }

        // GET: MusicGenres
        public async Task<IActionResult> Index()
        {
              return _context.MusicGenre != null ? 
                          View(await _context.MusicGenre.ToListAsync()) :
                          Problem("Entity set 'CSCI213___Assignment_5Context.MusicGenre'  is null.");
        }

        // GET: MusicGenres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MusicGenre == null)
            {
                return NotFound();
            }

            var musicGenre = await _context.MusicGenre
                .FirstOrDefaultAsync(m => m.GenreID == id);
            if (musicGenre == null)
            {
                return NotFound();
            }

            return View(musicGenre);
        }

        // GET: MusicGenres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MusicGenres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenreID,GenreName")] MusicGenre musicGenre)
        {
            if (ModelState.IsValid)
            {
                _context.Add(musicGenre);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(musicGenre);
        }

        // GET: MusicGenres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MusicGenre == null)
            {
                return NotFound();
            }

            var musicGenre = await _context.MusicGenre.FindAsync(id);
            if (musicGenre == null)
            {
                return NotFound();
            }
            return View(musicGenre);
        }

        // POST: MusicGenres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenreID,GenreName")] MusicGenre musicGenre)
        {
            if (id != musicGenre.GenreID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(musicGenre);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MusicGenreExists(musicGenre.GenreID))
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
            return View(musicGenre);
        }

        // GET: MusicGenres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MusicGenre == null)
            {
                return NotFound();
            }

            var musicGenre = await _context.MusicGenre
                .FirstOrDefaultAsync(m => m.GenreID == id);
            if (musicGenre == null)
            {
                return NotFound();
            }

            return View(musicGenre);
        }

        // POST: MusicGenres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MusicGenre == null)
            {
                return Problem("Entity set 'CSCI213___Assignment_5Context.MusicGenre'  is null.");
            }
            var musicGenre = await _context.MusicGenre.FindAsync(id);
            if (musicGenre != null)
            {
                _context.MusicGenre.Remove(musicGenre);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusicGenreExists(int id)
        {
          return (_context.MusicGenre?.Any(e => e.GenreID == id)).GetValueOrDefault();
        }
    }
}
