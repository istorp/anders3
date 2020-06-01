using System.Linq;
using anders3.Dtos.Character;
using anders3.Dtos.Skill;
using anders3.Dtos.Weapon;
using anders3.Models;
using AutoMapper;

namespace anders3
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>()
                  .ForMember(dto => dto.Skills, c => c.MapFrom(c=> c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
        }
        
    }
}