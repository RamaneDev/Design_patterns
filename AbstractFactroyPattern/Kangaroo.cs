using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactroyPattern
{
    public class Kangaroo : Carnivore
    {
        public override void Eat(Herbivore berbivore)
        {
            throw new NotImplementedException();
        }
    }
}