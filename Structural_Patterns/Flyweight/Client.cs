using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_patterns.Structural_Patterns.Flyweight
{
    // Client code
    public class Client
    {
        private List<ICharacter> _characters = new List<ICharacter>();
        private CharacterFactory _factory;

        public Client(CharacterFactory factory)
        {
            this._factory = factory;
        }

        public void AddCharacter(char symbol)
        {
            _characters.Add(_factory.GetCharacter(symbol));
        }

        public void DisplayCharacters()
        {
            foreach (ICharacter character in _characters)
            {
                character.Display();
            }
        }
    }
}