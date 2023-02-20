using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.Flyweight
{
    public class Character : ICharacter
    {
        private char _symbol;

        public Character(char symbol)
        {
            this._symbol = symbol;
        }

        public void Display()
        {
            Console.WriteLine("Symbol: " + _symbol);
        }
    }
}