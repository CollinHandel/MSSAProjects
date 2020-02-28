using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInheritanceClassLibrary
{
    public class Humvee : Vehicles
    {
        public override string Start() => "Press button";

        public override string Move() => "Presses gas peddle";
    }
}
