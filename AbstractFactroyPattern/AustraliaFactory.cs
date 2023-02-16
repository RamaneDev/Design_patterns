using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactroyPattern
{
    public class AustraliaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Kangaroo();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Dingo();
        }
    }
}