using System.Collections.Generic;
using anders3.Models;

namespace anders3.Properties.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
         
    }
}