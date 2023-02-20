using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.Mediator
{
      /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator mediator;
        // Constructor
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}