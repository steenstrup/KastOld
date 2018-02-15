using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kast.Models.Dnd5E;

namespace Kast.Controllers
{
    public class SpellsController : Controller
    {
        private readonly Dnd5EContext _context;

        public SpellsController(Dnd5EContext context)
        {
            _context = context;
        }

        // GET: Spells
        public async Task<IActionResult> Index()
        {
            return View(await _context.Spells.ToListAsync());
        }

        // GET: Spells/spells
        public async Task<IActionResult> Spells()
        {
            return View(await _context.Spells.ToListAsync());
        }

        // GET: Spells/spells/level
        public async Task<IActionResult> Spells(int level)
        {
            return View(await _context.Spells.Where(x => x.Level == level).ToListAsync());
        }

        // GET: Spells/SpellsDescription
       // public async Task<IActionResult> SpellsDescription()
        //{
       //     return View(await _context.Spells.ToListAsync());
        //}

        // GET: Spells/SpellsDescription
        public async Task<IActionResult> SpellsDescription(int? level)
        {
            if (level == null)
                return View(await _context.Spells.ToListAsync());
            return View(await _context.Spells.Where(x => x.Level == level).ToListAsync());
        }

        // GET: Spells/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spell = await _context.Spells
                .SingleOrDefaultAsync(m => m.SpellId == id);
            if (spell == null)
            {
                return NotFound();
            }

            return View(spell);
        }

        // GET: Spells/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Spells/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpellId,Name,Level,Schole,Retual,CastingTime,Range,Components,Duration,Description,Damage,DamageType")] Spell spell)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spell);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(spell);
        }

        // GET: Spells/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spell = await _context.Spells.SingleOrDefaultAsync(m => m.SpellId == id);
            if (spell == null)
            {
                return NotFound();
            }
            return View(spell);
        }

        // POST: Spells/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpellId,Name,Level,Schole,Retual,CastingTime,Range,Components,Duration,Description,Damage,DamageType")] Spell spell)
        {
            if (id != spell.SpellId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spell);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpellExists(spell.SpellId))
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
            return View(spell);
        }

        // GET: Spells/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spell = await _context.Spells
                .SingleOrDefaultAsync(m => m.SpellId == id);
            if (spell == null)
            {
                return NotFound();
            }

            return View(spell);
        }

        // POST: Spells/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spell = await _context.Spells.SingleOrDefaultAsync(m => m.SpellId == id);
            _context.Spells.Remove(spell);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpellExists(int id)
        {
            return _context.Spells.Any(e => e.SpellId == id);
        }
    }
}
