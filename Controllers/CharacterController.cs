using anders3.Models;
using Microsoft.AspNetCore.Mvc;

namespace anders3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
        public IActionResult Get()
        {
            return Ok(knight);
        }
    }
}