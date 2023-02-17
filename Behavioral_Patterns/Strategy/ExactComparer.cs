using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    public class ExactComparer : INameComparer
    {
        public bool Compare(string name, FullName record)
        {
            // Exact Impl of compare algo
            throw new NotImplementedException();
        }
    }
}