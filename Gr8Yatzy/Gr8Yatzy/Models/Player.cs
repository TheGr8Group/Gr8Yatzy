using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr8Yatzy
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public Protocol PlayerProtocol { get; set; }
    }
}
