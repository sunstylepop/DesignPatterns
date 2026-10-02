using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Sample
{
    class WeaponFactory
    {
        public static IWeapon? createWeapon(string type)
        {
            return type.ToLower() switch
            {
                "sword" => new Sword(),
                "bow" => new Bow(),
                "staff" => new Staff(),
                _ => null
            };
        }
    }
}
