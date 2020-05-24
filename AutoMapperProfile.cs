using anders3.Dtos.Character;
using anders3.Dtos.Weapon;
using anders3.Models;
using AutoMapper;

namespace anders3
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
        }
        
    }
}