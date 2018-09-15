using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr8Yatzy
{
    public enum YatzyRow
    {
        Ones, Twos, Threes, Fours, Fives, Sixes, OnePair, TwoPair, ThreeOfAKind, FourOfAKind, SmallStraight, LargeStraight, FullHouse, Chance, Yatzy
    }
    public class Protocol
    {
        private int result;

        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        public int UpperSum { get; set; }


        public int Bonus { get; private set; } 

        public int OnePair { get; set; }
        public int TwoPair { get; set; }
        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int FullHouse { get; set; }
        public int Chance { get; set; }
        public int Yatzy { get { return 50; } }// Behöver dubbelkolla om det funkar
        public int TotalSum { get; set; }

        public void SetBonus()
        {
            if (UpperSum >= 63)
            {
                Bonus = 50;
                UpperSum += Bonus;
            }
        }
        public bool IsOnes { get; set; }
        public bool IsTwos { get; set; }
        public bool IsThrees { get; set; }
        public bool IsFours { get; set; }
        public bool IsFives { get; set; }
        public bool IsSixes { get; set; }

        public bool IsOnePair { get; set; }
        public bool IsTwoPair { get; set; }
        public bool IsThreeOfAKind { get; set; }
        public bool IsFourOfAKind { get; set; }
        public bool IsSmallStraight { get; set; }
        public bool IsLargeStraight { get; set; }
        public bool IsFullHouse { get; set; }
        public bool IsChance { get; set; }
        public bool IsYatzy { get; set; }

        public void SetRowPoints(int result, YatzyRow row)
        {
            switch (row)
            {
                case YatzyRow.Ones:
                    Ones = result;
                    break;
                case YatzyRow.Twos:
                    Twos = result;
                    break;
                case YatzyRow.Threes:
                    Threes = result;
                    break;
                case YatzyRow.Fours:
                    Fours = result;
                    break;
                case YatzyRow.Fives:
                    Fives = result;
                    break;
                case YatzyRow.Sixes:
                    Sixes = result;
                    break;
                    //Kan inte räkna ut dessa än
                    //case YatzyRow.OnePair:
                    //    break;
                    //case YatzyRow.TwoPair:
                    //    break;
                    //case YatzyRow.ThreeOfAKind:
                    //    break;
                    //case YatzyRow.FourOfAKind:
                    //    break;
                    //case YatzyRow.SmallStraight:
                    //    break;
                    //case YatzyRow.LargeStraight:
                    //    break;
                    //case YatzyRow.FullHouse:
                    //    break;
                    //case YatzyRow.Chance:
                    //    break;
                    //case YatzyRow.Yatzy:
                    //    break;
                    //default:
                    //    break;
            }
        }
    }
}
