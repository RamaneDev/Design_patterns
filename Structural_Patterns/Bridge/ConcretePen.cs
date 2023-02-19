using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.Bridge
{
    public class ConcretePen : PenAbstraction
    {
        public ConcretePen()
        {
        }

        public ConcretePen(string color) : base(color)
        {
        }
    }
}