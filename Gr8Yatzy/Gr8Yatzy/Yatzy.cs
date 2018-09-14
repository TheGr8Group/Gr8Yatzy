using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr8Yatzy
{
    class Yatzy
    {
        public int GameID { get; set; }
        public int Rolls { get; set; }
        public List<Player> Players { get; set; }// hur sätta ett maxvärde till en lista?
        public int MaxAllowedPlayers { get; set; }
        public int MinAllowedPlayers { get; set; }
        public int[] Dices { get; set; }


    }
}
