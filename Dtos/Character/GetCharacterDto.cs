using System.Collections.Generic;
using anders3.Dtos.Skill;
using anders3.Dtos.Weapon;
using anders3.Models;

namespace anders3.Dtos.Character
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; }="Anders";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto Weapon {get; set;}
        public List<GetSkillDto> Skills { get; set; }
        public int Fight { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}