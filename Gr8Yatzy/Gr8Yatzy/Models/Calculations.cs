using System;
using System.Collections.Generic;
using System.Linq;

namespace Gr8Yatzy
{
    public class Calculations
    {
        Protocol proto = new Protocol();


        public Yatzy SetUpperSum(/*Yatzy yatzy*/)
        {
            //Start Testkod
            Player pl;
            Yatzy yatzy = new Yatzy() { GameID = 1, Players = new List<Player>() };
            pl = new Player() { NickName = "w00t", PlayerProtocol = new Protocol() };
            yatzy.Players.Add(pl);
            pl = new Player() { NickName = "Maestro", PlayerProtocol = new Protocol() };
            yatzy.Players.Add(pl);
            // Slut testkod

            int resultUpper = 0;
            foreach (Player p in yatzy.Players)
            {
                resultUpper += p.PlayerProtocol.Ones;
                resultUpper += p.PlayerProtocol.Twos;
                resultUpper += p.PlayerProtocol.Threes;
                resultUpper += p.PlayerProtocol.Fours;
                resultUpper += p.PlayerProtocol.Fives;
                resultUpper += p.PlayerProtocol.Sixes;
                p.PlayerProtocol.UpperSum = resultUpper;
                p.PlayerProtocol.SetBonus();
                SetTotalSum(yatzy);
            }
            return yatzy;
        }

        private void SetTotalSum(Yatzy yatzy)
        {
            int resultLower = 0;
            foreach (Player p in yatzy.Players)
            {
                resultLower += p.PlayerProtocol.OnePair;
                resultLower += p.PlayerProtocol.TwoPair;
                resultLower += p.PlayerProtocol.ThreeOfAKind;
                resultLower += p.PlayerProtocol.FourOfAKind;
                resultLower += p.PlayerProtocol.SmallStraight;
                resultLower += p.PlayerProtocol.LargeStraight;
                resultLower += p.PlayerProtocol.FullHouse;
                resultLower += p.PlayerProtocol.Yatzy;
                resultLower += p.PlayerProtocol.Chance;

                p.PlayerProtocol.TotalSum += p.PlayerProtocol.UpperSum + resultLower;
            }



        }
    }
}
