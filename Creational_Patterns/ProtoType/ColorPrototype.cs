using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Creational_Patterns.ProtoType
{
      /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }
    
}