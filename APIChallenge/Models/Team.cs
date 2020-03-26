using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;

namespace APIChallenge.Models
{
    public class Team
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public List<Player> Players { get; set; }
    }
}
