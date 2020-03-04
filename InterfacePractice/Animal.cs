using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public abstract  class Animal
    {
        public string Habitat { get; set; }

        public virtual string Breathe()
        {
            return "Abstract breathing";
        }
    }
}
