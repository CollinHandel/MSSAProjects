using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Mammal : Animal, IMammal
    {
        public string LiveBirth()
        {
            return "My! Six babies born today!";
        }
    }

}
