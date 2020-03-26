using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInheritanceClassLibrary
{
    public class Vehicles
    {
        public virtual string Start() => "Default start";

        public virtual string Move() => "Default move";
    }
}
