using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BiavlerWeb.Areas.Identity.Data;
using BiavlerWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;

namespace BiavlerWeb.Controllers
{
    public class VarroataellingsController : Controller
    {
        private readonly BiavlerWebContext _context;

        public VarroataellingsController(BiavlerWebContext context)
        {
            _context = context;
        }

        // GET: Varroataellings
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View(await _context.Varroataellinger.Where(id => id.UserId == userId).ToListAsync());
        }

        // GET: Varroataellings/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var varroataelling = await _context.Varroataellinger
                .FirstOrDefaultAsync(m => m.Id == id);
            if (varroataelling == null)
            {
                return NotFound();
            }

            return View(varroataelling);
        }

        // GET: Varroataellings/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        protected UserManager<BiavlerWebUser> UserManager { get; set; }

        // POST: Varroataellings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Bistade,Dato,AntalVarroamider,Observationsvarighed,Bemaerkning")] Varroataelling varroataelling)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            varroataelling.UserId = userId;
            
            if (ModelState.IsValid)
            {
                _context.Add(varroataelling);
                await _context.SaveChangesAsync();
                return View();
            }
            return View(varroataelling);
        }

        // GET: Varroataellings/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var varroataelling = await _context.Varroataellinger.FindAsync(id);
            if (varroataelling == null)
            {
                return NotFound();
            }
            return View(varroataelling);
        }

        // POST: Varroataellings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Bistade,Dato,AntalVarroamider,Observationsvarighed,Bemaerkning")] Varroataelling varroataelling)
        {
            if (id != varroataelling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    varroataelling.UserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                    _context.Update(varroataelling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VarroataellingExists(varroataelling.Id))
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
            return View(varroataelling);
        }

        // GET: Varroataellings/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var varroataelling = await _context.Varroataellinger
                .FirstOrDefaultAsync(m => m.Id == id);
            if (varroataelling == null)
            {
                return NotFound();
            }

            return View(varroataelling);
        }

        // POST: Varroataellings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var varroataelling = await _context.Varroataellinger.FindAsync(id);
            _context.Varroataellinger.Remove(varroataelling);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VarroataellingExists(long id)
        {
            return _context.Varroataellinger.Any(e => e.Id == id);
        }
    }
}
