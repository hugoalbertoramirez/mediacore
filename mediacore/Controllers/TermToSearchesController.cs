using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mediacore.Models;

namespace mediacore.Controllers
{
    public class TermToSearchesController : Controller
    {
        private readonly DB_medIAContext _context;

        public TermToSearchesController(DB_medIAContext context)
        {
            _context = context;
        }

        // GET: TermToSearches
        public async Task<IActionResult> Index()
        {
            return View(await _context.TermToSearch.ToListAsync());
        }

        // GET: TermToSearches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termToSearch = await _context.TermToSearch
                .SingleOrDefaultAsync(m => m.Id == id);
            if (termToSearch == null)
            {
                return NotFound();
            }

            return View(termToSearch);
        }

        // GET: TermToSearches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TermToSearches/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Term,IsTrending,Status")] TermToSearch termToSearch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(termToSearch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(termToSearch);
        }

        // GET: TermToSearches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termToSearch = await _context.TermToSearch.SingleOrDefaultAsync(m => m.Id == id);
            if (termToSearch == null)
            {
                return NotFound();
            }
            return View(termToSearch);
        }

        // POST: TermToSearches/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Term,IsTrending,Status")] TermToSearch termToSearch)
        {
            if (id != termToSearch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(termToSearch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TermToSearchExists(termToSearch.Id))
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
            return View(termToSearch);
        }

        // GET: TermToSearches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var termToSearch = await _context.TermToSearch
                .SingleOrDefaultAsync(m => m.Id == id);
            if (termToSearch == null)
            {
                return NotFound();
            }

            return View(termToSearch);
        }

        // POST: TermToSearches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var termToSearch = await _context.TermToSearch.SingleOrDefaultAsync(m => m.Id == id);
            _context.TermToSearch.Remove(termToSearch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TermToSearchExists(int id)
        {
            return _context.TermToSearch.Any(e => e.Id == id);
        }
    }
}
