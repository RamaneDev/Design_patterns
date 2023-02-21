using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.State
{
     /// <summary>
    /// A 'ConcreteState' class
    /// </summary>
    public class ConcreteStateA : AbstractState
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }
}