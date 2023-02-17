using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.AdapterPattern
{
        /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}