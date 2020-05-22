using System.Collections.Generic;
using System.Threading.Tasks;
using anders3.Dtos.Character;
using anders3.Models;

namespace anders3.Properties.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(int userId);
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
         
    }
}