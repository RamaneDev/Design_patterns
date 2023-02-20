using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.Iterator
{
    /// <summary>
    /// The 'Aggregate' abstract class
    /// </summary>
    public abstract class AbstractAggregate
    {
        public abstract AbstractIterator CreateIterator();
    }
}