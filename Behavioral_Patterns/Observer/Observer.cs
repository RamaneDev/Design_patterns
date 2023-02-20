using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.Observer
{
     /// <summary>
    /// The 'Observer' abstract class
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }
}