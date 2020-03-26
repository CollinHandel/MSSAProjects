using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInheritanceClassLibrary
{
    public class LargeCaliberWeapon : Weapons
    {
        public override string Load() => "Stabilizes weapon, pulls out big magazine and loads it.";

        public override string Fire() => "BANG";
    }
}
