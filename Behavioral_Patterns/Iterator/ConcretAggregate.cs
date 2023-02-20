using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Behavioral_Patterns.Iterator
{
   /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    public class ConcreteAggregate : AbstractAggregate
    {
        List<object> items = new List<object>();
        public override AbstractIterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        // Get item count
        public int Count
        {
            get { return items.Count; }
        }
        // Indexer
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}