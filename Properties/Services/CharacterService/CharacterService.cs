using System.Collections.Generic;
using System.Linq;
using anders3.Models;

namespace anders3.Properties.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters =new List<Character>
        {
            new Character(),
            new Character { Id = 1, Name = "sam"}
        };
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return (characters);
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.Id == id);
        }
    }
}