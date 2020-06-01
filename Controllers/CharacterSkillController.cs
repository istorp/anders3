using System.Threading.Tasks;
using anders3.Dtos.CharacterSkill;
using anders3.Properties.Services.CharacterSkillService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace anders3.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CharacterSkillController : ControllerBase
    {
        private readonly ICharacterSkillService __characterSkillService;
        public CharacterSkillController(ICharacterSkillService _characterSkillService)
        {
            __characterSkillService = _characterSkillService;

        }
        [HttpPost]
        public async Task<IActionResult> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            return Ok(await __characterSkillService.AddCharacterSkill(newCharacterSkill));
        }

    }
}