using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInheritanceClassLibrary
{
    public class Helicopter : Vehicles
    {
        public override string Start() => "Flips switch";

        public override string Move() => "Pushes joy stick forward";
    }
}
