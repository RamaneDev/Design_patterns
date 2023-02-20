using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.Flyweight
{
    // Flyweight Factory
    public class CharacterFactory
    {
        private Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

        public ICharacter GetCharacter(char symbol)
        {
            if (!_characters.ContainsKey(symbol))
            {
                _characters.Add(symbol, new Character(symbol));
            }
            return _characters[symbol];
        }

        public void DesplayFactoryObjectCount()
        {
            Console.WriteLine(string.Format("There are {0} objects in the factory", _characters.Count));
        }
    }
}