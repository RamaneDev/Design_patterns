using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Strategy
{
    public struct FullName
    {
        public string FirstName;
        public string LastName;

        public FullName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    public interface INameComparer
    {
        bool Compare(string name, FullName record);
    }
}