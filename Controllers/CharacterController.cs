using System.Collections.Generic;
using System.Linq;
using anders3.Models;
using anders3.Properties.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace anders3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {

        
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;

        }
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(_characterService.GetAllCharacters());
        }
        [HttpGet("{id}")]
        public IActionResult GetSingel(int id)
        {
            return Ok(_characterService.GetCharacterById(id));
        }
        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}