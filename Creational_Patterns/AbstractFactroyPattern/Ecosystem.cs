using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.AbstractFactroyPattern
{
    public class Ecosystem
    {
       private Herbivore _herbivore;
       private Carnivore _carnivore;

       public Ecosystem(ContinentFactory factory)
       {
         _herbivore = factory.CreateHerbivore();
         _carnivore = factory.CreateCarnivore();        
       }

       public void Run()
       {
         _carnivore.Eat(_herbivore);
       }

    }
}