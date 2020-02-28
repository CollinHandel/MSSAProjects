using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInheritanceClassLibrary
{
    public class Weapons
    {
        public virtual string Load() => "Default load weapon";

        public virtual string Fire() => "Default fire weapon";
    }
}
