using System.Collections.Generic;
using System.Threading.Tasks;
using anders3.Models;

namespace anders3.Properties.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<List<Character>> GetAllCharacters();
         Task<Character> GetCharacterById(int id);
         Task<List<Character>> AddCharacter(Character newCharacter);
         
    }
}