using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.AdapterPattern
{
   /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}