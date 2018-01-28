using Kast.Models.DnD5E;
using System.Collections.Generic;

namespace Kast.Models
{
    public interface ICharecterRepository
    {

        IEnumerable<Character> Charecters { get; }

        Topic GetTopicCharecterId(int charecterId);
    }
}