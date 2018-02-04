using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kast.Models.Dnd5E
{
    public class FeaturesAndTraits
    {
        public string Name { get;}

        public string LongDescription { get; }

        public string ShortDescription { get; }

        public FeaturesAndTraits(string name)
        {
            Name = name;
            LongDescription = "";
            ShortDescription = "";
        }
    }
}
