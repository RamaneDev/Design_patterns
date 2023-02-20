using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.Mediator
{
     /// <summary>
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class Mediator
    {
        public abstract void Send(string message,
            Colleague colleague);
    }
}