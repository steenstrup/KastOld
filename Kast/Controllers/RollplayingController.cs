using Kast.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Kast.Models.Dnd5E;
using Kast.Models.Repositorys;

namespace Kast.Controllers 
{
    public class RollplayingController : Controller
    {
        private readonly ICharecterRepository _charecterRepository;
        private readonly Dnd5EContext _context;

        public RollplayingController(ICharecterRepository charecterRepository, Dnd5EContext context)
        {
            _charecterRepository = charecterRepository;
            _context = context;
        }
        
        public ViewResult Dnd5ECharaters(int id)
        {
            return View(_charecterRepository.Charecters.Where(c => c.CharacterId == id));
        }

        public ViewResult Dnd5EEquipment(int id)
        {
            return View(_charecterRepository.Charecters.Where(c => c.CharacterId == id));
        }

    }
}
