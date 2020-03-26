using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInheritanceClassLibrary
{
    public class SmallCaliberWeapon : Weapons
    {
        public override string Load() => "Loads small magazine.";

        public override string Fire() => "Pew pew";
    }
}
