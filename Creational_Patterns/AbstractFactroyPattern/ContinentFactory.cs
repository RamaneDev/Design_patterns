using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactroyPattern
{
    public abstract class ContinentFactory
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
    }
}