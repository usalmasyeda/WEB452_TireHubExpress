using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TireHubExpress.Data;
using TireHubExpress.Models;

namespace TireHubExpress.Controllers
{
    public class TiresController : Controller
    {
        private readonly TireHubExpressContext _context;

        public TiresController(TireHubExpressContext context)
        {
            _context = context;
        }

        // GET: Tires
        /*  public async Task<IActionResult> Index()
          {
              return View(await _context.Tire.ToListAsync());
          }*/

        /* public async Task<IActionResult> Index(string searchString)
         {
             var Tires = from m in _context.Tire
                          select m;

             if (!String.IsNullOrEmpty(searchString))
             {
                 Tires = Tires.Where(s => s.Name.Contains(searchString));
             }

             return View(await Tires.ToListAsync());
         }*/

        // GET: Movies
        public async Task<IActionResult> Index(string tireType, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> typeQuery = from m in _context.Tire
                                            orderby m.Type
                                            select m.Type;

            var tires = from m in _context.Tire
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                tires = tires.Where(s => s.Type.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(tireType))
            {
                tires = tires.Where(x => x.Type == tireType);
            }

            var tireTypeVM = new TireTypeViewModel
            {
                Types = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Tires = await tires.ToListAsync()
            };

            return View(tireTypeVM);
        }

        // GET: Tires/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tire = await _context.Tire
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tire == null)
            {
                return NotFound();
            }

            return View(tire);
        }

        // GET: Tires/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tires/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Material,Durability,Stock,Price,Review")] Tire tire)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tire);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tire);
        }

        // GET: Tires/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tire = await _context.Tire.FindAsync(id);
            if (tire == null)
            {
                return NotFound();
            }
            return View(tire);
        }

        // POST: Tires/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Material,Durability,Stock,Price,Review")] Tire tire)
        {
            if (id != tire.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tire);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TireExists(tire.Id))
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
            return View(tire);
        }

        // GET: Tires/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tire = await _context.Tire
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tire == null)
            {
                return NotFound();
            }

            return View(tire);
        }

        // POST: Tires/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tire = await _context.Tire.FindAsync(id);
            _context.Tire.Remove(tire);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TireExists(int id)
        {
            return _context.Tire.Any(e => e.Id == id);
        }
    }
}
