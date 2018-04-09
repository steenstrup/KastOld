using System.Collections.Generic;
using Kast.Models.Dnd5E;

namespace Kast.Models.Repositorys
{
    public interface ICharecterRepository
    {

        IEnumerable<Character> Charecters { get; }

        Topic GetCharecterId(int charecterId);
    }
}