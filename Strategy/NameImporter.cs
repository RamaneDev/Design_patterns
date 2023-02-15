using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    public class NameImporter
    {
        private readonly INameComparer _comparer;

        public NameImporter(INameComparer comparer)
        {
            _comparer = comparer;
        }


        public void Match(FullName[] database, string[] importList)
        {
            foreach (string name in importList)
            {
                foreach (FullName record in database)
                {
                    // the compare method used below depends 
                    // of the type of comparer injected in the constructor
                    if(_comparer.Compare(name, record))
                    {
                        Console.WriteLine("the name match the recorded name");
                    }
                }

            }
        }
    }
}