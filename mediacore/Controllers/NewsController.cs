using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mediacore.Models;
using mediacore.ViewModels;

namespace mediacore.Controllers
{
    public class NewsController : Controller
    {
        private readonly DB_medIAContext _context;

        public NewsController(DB_medIAContext context)
        {
            _context = context;
        }

        // GET: News
        public async Task<IActionResult> Index(string sortOrder, string relatedWord, string idPublisher, string idTopic, DateTime? startDate, DateTime? endDate, 
            string idState, int? newsByPage, string idNews, string areImportants, int? page)
        {
            /////////
            var _mainPublishers = from p in _context.Publisher
                                  join mp in _context.MainPublisher on p.Id equals mp.IdPublisher
                                  select new { p.Id, p.Name };

            ViewData["MainPublishers"] = new SelectList(_mainPublishers, "Id", "Name");
            /////////
            var _topics = from t in _context.TermToSearch
                          select new { t.Id, t.Term };

            ViewData["Topics"] = new SelectList(_topics, "Id", "Term");
            /////////
            var _states = from s in _context.State
                          select new { s.Id, s.Name };

            ViewData["States"] = new SelectList(_states, "Id", "Name");
            /////////

            ViewData["areImportants"] = string.IsNullOrWhiteSpace(areImportants) ? "1" : areImportants;
            ViewData["idNews"] = string.IsNullOrEmpty(idNews) ? "" : null;
            //ViewData["newsByPage"] = newsByPage = string.IsNullOrEmpty(newsByPage) ? "10" : newsByPage;
            ViewData["RelatedWord"] = relatedWord;
            ViewData["IdPublisher"] = string.IsNullOrEmpty(idPublisher) ? "-1" : null;
            ViewData["idTopic"] = string.IsNullOrEmpty(idTopic) ? "-1" : null;
            ViewData["idState"] = string.IsNullOrEmpty(idState) ? "-1" : null;
            ViewData["startDate"] = startDate = startDate.HasValue ? startDate : new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            ViewData["endDate"] = endDate = endDate.HasValue ? endDate : new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1);

            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            

            var _news = from s in _context.News select s;

            int idNewsint;
            if (!string.IsNullOrEmpty(idNews) && int.TryParse(idNews, out idNewsint) && idNewsint != -1)
            {
                _news = from n in _news
                        where n.Id == idNewsint
                        select n;
            }
            if (startDate.HasValue && startDate.Value.Year > 1899)
            {
                _news = _news.Where(n => n.DatePublished >= startDate.Value);
            }
            if (endDate.HasValue && endDate.Value.Year > 1899)
            {
                _news = _news.Where(n => n.DatePublished <= endDate.Value);
            }
            int idPublisherint;
            if (!string.IsNullOrEmpty(idPublisher) && int.TryParse(idPublisher, out idPublisherint) && idPublisherint != -1)
            {
                if (idPublisherint == -2)
                {
                    _news = from n in _news
                            join np in _context.NewsPublisher on n.Id equals np.IdNews
                            join p in _context.Publisher on np.IdPublisher equals p.Id
                            join mp in _context.MainPublisher on p.Id equals mp.IdPublisher
                            select n;
                }
                else
                {
                    _news = from n in _news
                            join np in _context.NewsPublisher on n.Id equals np.IdNews
                            where np.IdPublisher == idPublisherint
                            select n;
                }
            }
            int idTopicint;
            if (!string.IsNullOrEmpty(idTopic) && int.TryParse(idTopic, out idTopicint) && idTopicint != -1)
            {
                if (idTopicint == -2)
                {
                    _news = from n in _news
                            join nt in _context.NewsTermToSearch on n.Id equals nt.IdNews
                            join t in _context.TermToSearch on nt.IdTermToSearch equals t.Id
                            where t.IsTrending
                            select n;
                }
                else
                {
                    _news = from n in _news
                            join t in _context.NewsTermToSearch on n.Id equals t.IdNews
                            where t.IdTermToSearch == idTopicint
                            select n;
                }
            }
            int idStateint;
            if (!string.IsNullOrEmpty(idState) && int.TryParse(idState, out idStateint) && idStateint != -1)
            {
                _news = from s in _context.State
                        join ps in _context.PublisherState on s.Id equals ps.IdState
                        join p in _context.Publisher on ps.IdPublisher equals p.Id
                        join np in _context.NewsPublisher on p.Id equals np.IdPublisher
                        join n in _news on np.IdNews equals n.Id
                        where s.Id == idStateint
                        select n;
            }
            if (!string.IsNullOrEmpty(relatedWord))
            {
                _news = _news.Where(s => s.Name.Contains(relatedWord) || s.Description.Contains(relatedWord));
            }
            int areImportantint;
            if (!string.IsNullOrEmpty(areImportants) && int.TryParse(areImportants, out areImportantint))
            {
                switch (areImportantint)
                {
                    case 1: // all
                        break;
                    case 2: // important
                        _news = from n in _news
                                join imn in _context.ImportantNews on n.Id equals imn.IdNews
                                select n;
                        break;
                }
            }


            switch (sortOrder)
            {
                case "name_desc":
                    _news = _news.OrderByDescending(s => s.Name);
                    break;
                case "Date":
                    _news = _news.OrderBy(s => s.DatePublished);
                    break;
                case "date_desc":
                    _news = _news.OrderByDescending(s => s.DatePublished);
                    break;
                default:
                    _news = _news.OrderBy(s => s.Name);
                    break;
            }

            _news = _news
                .Distinct()
                //.Include(n => n.NewsPublisher)
                //.Include(n => n.IdCategoryNavigation)
                //.Include(n => n.IdClassificationNavigation)
                //.Include(n => n.IdOpinionNavigation)
                .Include(n => n.ImportantNews)
                .OrderBy(n => n.DatePublished);

            // paginado:

            int newsByPageInt = newsByPage.HasValue ? newsByPage.Value : 10;
            int pageint = page.HasValue ? page.Value : 1;
            int count = _news.Count();

            var viewModel = new ViewModelNews()
            {
                PageIndex = pageint,
                TotalPages = (int)Math.Ceiling(count / (double)newsByPageInt),

                areImportants = areImportants,
                startDate = startDate,
                endDate = endDate,
                news = await _news.Skip((pageint - 1) * newsByPageInt).Take(newsByPageInt).ToListAsync()
            };
            return View(viewModel);
        }

        // GET: News/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.IdCategoryNavigation)
                .Include(n => n.IdClassificationNavigation)
                .Include(n => n.IdOpinionNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // GET: News/Create
        public IActionResult Create()
        {
            ViewData["IdCategory"] = new SelectList(_context.Category, "Id", "Name");
            ViewData["IdClassification"] = new SelectList(_context.Classification, "Id", "Name");
            ViewData["IdOpinion"] = new SelectList(_context.Opinion, "Id", "Id");
            return View();
        }

        // POST: News/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdCategory,DatePublished,Name,Url,Description,Text,Status,IdOpinion,IdClassification,IsHeadline")] News news)
        {
            if (ModelState.IsValid)
            {
                _context.Add(news);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCategory"] = new SelectList(_context.Category, "Id", "Name", news.IdCategory);
            ViewData["IdClassification"] = new SelectList(_context.Classification, "Id", "Name", news.IdClassification);
            ViewData["IdOpinion"] = new SelectList(_context.Opinion, "Id", "Id", news.IdOpinion);
            return View(news);
        }

        // GET: News/Edit/5
        public async Task<IActionResult> Edit(int? id, string sortOrder, string relatedWord, string idPublisher, string idTopic, string startDate, string endDate)
        {
            ViewData["RelatedWord"] = relatedWord;
            ViewData["IdPublisher"] = string.IsNullOrEmpty(idPublisher) ? "-1" : null;
            ViewData["idTopic"] = string.IsNullOrEmpty(idTopic) ? "-1" : null;
            ViewData["startDate"] = startDate;
            ViewData["endDate"] = endDate;

            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News.SingleOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }
            ViewData["IdCategory"] = new SelectList(_context.Category, "Id", "Name", news.IdCategory);
            ViewData["IdClassification"] = new SelectList(_context.Classification, "Id", "Name", news.IdClassification);
            ViewData["IdOpinion"] = new SelectList(_context.Opinion, "Id", "Id", news.IdOpinion);
            return View(news);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdCategory,DatePublished,Name,Url,Description,Text,Status,IdOpinion,IdClassification,IsHeadline")] News news)
        {
            if (id != news.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(news);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NewsExists(news.Id))
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
            ViewData["IdCategory"] = new SelectList(_context.Category, "Id", "Name", news.IdCategory);
            ViewData["IdClassification"] = new SelectList(_context.Classification, "Id", "Name", news.IdClassification);
            ViewData["IdOpinion"] = new SelectList(_context.Opinion, "Id", "Id", news.IdOpinion);
            return View(news);
        }

        // GET: News/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var news = await _context.News
                .Include(n => n.IdCategoryNavigation)
                .Include(n => n.IdClassificationNavigation)
                .Include(n => n.IdOpinionNavigation)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (news == null)
            {
                return NotFound();
            }

            return View(news);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var news = await _context.News.SingleOrDefaultAsync(m => m.Id == id);
            _context.News.Remove(news);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }
    }
}
