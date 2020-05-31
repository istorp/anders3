using System;
using System.Security.Claims;
using System.Threading.Tasks;
using anders3.Data;
using anders3.Dtos.Character;
using anders3.Dtos.CharacterSkill;
using anders3.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace anders3.Properties.Services.CharacterSkillService
{
    public class CharacterSkillService : ICharacterSkillService
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;
        public CharacterSkillService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _context = context;

        }
        public async Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            ServiceResponse<GetCharacterDto> response =new ServiceResponse<GetCharacterDto>();
            try
            {
                Character character = await _context.Characters
                .Include(c => c.Weapon)
                .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                .FirstOrDefaultAsync(c => c.Id == newCharacterSkill.CharacterId && 
                c.User.Id == int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));
                if(character == null)
                {
                    response.Success=false;
                    response.Message="Character not found";
                    return response;
                }
                Skill skill = await _context.Skills
                .FirstOrDefaultAsync(s => s.Id == newCharacterSkill.SkillId);
                if(skill == null)

                {
                    response.Success=false;
                    response.Message="";
                    return response;
                }            }
            catch(Exception ex)
            {
                response.Success=false;
                response.Message=ex.Message;
            }
            return response;
        }
    }
}