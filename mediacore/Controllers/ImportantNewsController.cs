using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mediacore.Models;
using System.Web;
using mediacore.ViewModels;

namespace mediacore.Controllers
{
    public class ImportantNewsController : Controller
    {
        private readonly DB_medIAContext _context;

        public ImportantNewsController(DB_medIAContext context)
        {
            _context = context;
        }

        // GET: ImportantNews
        public async Task<IActionResult> Index()
        {
            var dB_medIAContext = _context.ImportantNews.Include(i => i.IdNewsNavigation).Include(i => i.IdUserNavigation);
            return View(await dB_medIAContext.ToListAsync());
        }

        // GET: ImportantNews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importantNews = await _context.ImportantNews
                .Include(i => i.IdNewsNavigation)
                .Include(i => i.IdUserNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (importantNews == null)
            {
                return NotFound();
            }

            return View(importantNews);
        }

        // GET: ImportantNews/Create
        public IActionResult Create(int? id)
        {
            var importanNew = from imn in _context.ImportantNews
                              where imn.IdNews == id && imn.IdUser == 1
                              select imn;

            bool exists = importanNew.SingleOrDefault() != null;
            ViewData["Exists"] = exists;
            if (exists)
            {
                ViewData["Id"] = importanNew.Single().Id;
            }


            ViewData["IdNews"] = id.HasValue ? id : null;
            //ViewData["IdNews"] = new SelectList(_context.News, "Id", "Id");
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "Email");

            if (id.HasValue)
            {
                var vm = new ViewModelImportantNews()
                {
                    importantNews = new ImportantNews() { IdUser = 1, IdNews = id.Value },
                    Exists = true,
                };

                return View(vm);
            }
            else
            {
                return View();
            }
        }

        // POST: ImportantNews/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUser,IdNews")] ImportantNews importantNews)
        {
            if (ModelState.IsValid)
            {
                _context.Add(importantNews);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNews"] = new SelectList(_context.News, "Id", "Id", importantNews.IdNews);
            //ViewData["IdUser"] = new SelectList(_context.User, "Id", "Email", importantNews.IdUser);
            return View(importantNews);
        }

        // GET: ImportantNews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importantNews = await _context.ImportantNews.SingleOrDefaultAsync(m => m.Id == id);
            if (importantNews == null)
            {
                return NotFound();
            }
            ViewData["IdNews"] = new SelectList(_context.News, "Id", "Id", importantNews.IdNews);
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "Email", importantNews.IdUser);
            return View(importantNews);
        }

        // POST: ImportantNews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdUser,IdNews,Status")] ImportantNews importantNews)
        {
            if (id != importantNews.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(importantNews);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ImportantNewsExists(importantNews.Id))
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
            ViewData["IdNews"] = new SelectList(_context.News, "Id", "Id", importantNews.IdNews);
            ViewData["IdUser"] = new SelectList(_context.User, "Id", "Email", importantNews.IdUser);
            return View(importantNews);
        }

        // GET: ImportantNews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var importantNews = await _context.ImportantNews
                .Include(i => i.IdNewsNavigation)
                .Include(i => i.IdUserNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (importantNews == null)
            {
                return NotFound();
            }

            return View(importantNews);
        }

        // POST: ImportantNews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var importantNews = await _context.ImportantNews.SingleOrDefaultAsync(m => m.Id == id);
            _context.ImportantNews.Remove(importantNews);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ImportantNewsExists(int id)
        {
            return _context.ImportantNews.Any(e => e.Id == id);
        }
    }
}
