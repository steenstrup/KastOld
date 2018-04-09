using Kast.Roleplaying.Models.Dnd5Edition;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Kast.Roleplaying.Controllers
{
    public class SpellBookController : Controller
    {
        private readonly Dnd5EContext _context;

        public SpellBookController(Dnd5EContext context)
        {
            _context = context;
        }

        // GET: SpellBooks/Overview/5
        public async Task<IActionResult> Overview(int? id)
        {
            if (id == null)
                return NotFound();

            var spellBook = await _context.SpellBooks.Include(x => x.Spells)
                .SingleOrDefaultAsync(m => m.SpellBookId == id);

            if (spellBook == null)
                return NotFound();

            return View(spellBook);
        }

        // GET: SpellBooks/Detailed/5
        public async Task<IActionResult> Detailed(int? id)
        {
            if (id == null)
                return NotFound();

            var spellBook = await _context.SpellBooks.Include(x => x.Spells)
                .SingleOrDefaultAsync(m => m.SpellBookId == id);

            if (spellBook == null)
                return NotFound();

            return View(spellBook);
        }

    }
}