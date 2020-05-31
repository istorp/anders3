using System.Threading.Tasks;
using anders3.Dtos.Character;
using anders3.Dtos.CharacterSkill;
using anders3.Models;

namespace anders3.Properties.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
         Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}