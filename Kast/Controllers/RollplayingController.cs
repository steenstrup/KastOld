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
        
        public RollplayingController(ICharecterRepository charecterRepository)
        {
            _charecterRepository = charecterRepository;
        }
        
        public ViewResult Dnd5ECharaters(int id)
        {
            return View(_charecterRepository.Charecters.Where(c => c.CharacterId == id));
        }
        
    }
}
