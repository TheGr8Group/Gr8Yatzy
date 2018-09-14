using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr8Yatzy
{
    enum YatzyValues
    {
        Ones, Twos, Threes, Fours, Fives, Sixes, OnePair, TwoPair, ThreeOfAKind, FourOfAKind, SmallStraight, LargeSraight, FullHouse, Chance, Yatzy
    }
    class Protocol
    {
        private int result;

        public int Ones { get { return result; } set { Ones = result; } }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        public int UpperSum { get; set; }
        public int Bonus { get; set; } // Kan ju räkna ut bonusen direk och sätta värdet direkt i Bonus

        public int OnePair { get; set; }
        public int TwoPair { get; set; }
        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int FullHouse { get; set; }
        public int Chance { get; set; }
        public int Yatzy { get { return 50; } }
        public int TotalSum { get; set; }

    }
}
