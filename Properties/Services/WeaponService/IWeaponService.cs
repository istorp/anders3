using System.Threading.Tasks;
using anders3.Dtos.Character;
using anders3.Dtos.Weapon;
using anders3.Models;

namespace anders3.Properties.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}