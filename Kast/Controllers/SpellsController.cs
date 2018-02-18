using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        
        // GET: Spells/SpellsDescription
        public async Task<IActionResult> SpellsDescription(int? level)
        {
            if (level == null)
                return View(await _context.Spells.ToListAsync());
            return View(await _context.Spells.Where(x => x.Level == level).ToListAsync());
        }
        
    }
}
