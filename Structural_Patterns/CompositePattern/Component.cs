using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.CompositePattern
{
      /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class Component
    {
        protected string name;
        // Constructor
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
}