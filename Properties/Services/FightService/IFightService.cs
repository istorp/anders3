using System.Threading.Tasks;
using anders3.Dtos.Fight;
using anders3.Models;

namespace anders3.Properties.Services.FightService
{
    public interface IFightService
    {
         Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
         Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);

    }
}