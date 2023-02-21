using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.State
{
     /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class AbstractState
    {
        public abstract void Handle(Context context);
    }
}