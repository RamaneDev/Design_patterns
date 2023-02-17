using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactroyPattern
{
    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore berbivore);
    }
}