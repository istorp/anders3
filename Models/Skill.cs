using System.Collections.Generic;

namespace anders3.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Samage { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
    }
}