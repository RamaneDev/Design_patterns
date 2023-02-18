using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.ProxyPattern
{
     /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    public abstract class Subject
    {
        public abstract void Request();
    }
}