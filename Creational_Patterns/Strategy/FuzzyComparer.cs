using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    public class FuzzyComparer : INameComparer
    {
        public bool Compare(string name, FullName record)
        {
            // Fuzzy Impl of compare algo
            throw new NotImplementedException();
        }
    }
}