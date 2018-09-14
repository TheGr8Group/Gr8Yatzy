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
        //public int[] Dices { get; set; }

        int[] dices = new int[5]; // microsoft rekommenderar inte arrays som propertys. Vi kan göra den som field ist?
        bool[] savedDices = new bool[5];//test

        /// <summary>
        /// Kastar 5 tärningar.
        /// </summary>
        /// <returns></returns>
        public int[] RollDices(/*bool[] savedDices*/) // parameter utkommenterad för testnings skull
        {
            Random random = new Random();

            for (int i = 0; i < dices.Count(); i++)
            {
                if (!savedDices[i])
                {
                    dices[i] = random.Next(1, 7);
                }
            }

            //För testning
            //if (1 == 1)
            //{
            //    savedDices[0] = true;
            //    savedDices[1] = true;
            //    savedDices[2] = false;
            //    savedDices[3] = false;
            //    savedDices[4] = true;

            //}

            ClearArraySavedDices(savedDices);

            return dices;
        }

        /// <summary>
        /// Sätter savedDices till false inför nästa players omgång
        /// </summary>
        /// <param name="savedDices"></param>
        private void ClearArraySavedDices(bool[] savedDices)
        {
            Rolls++;

            if (Rolls == 3)
            {
                for (int i = 0; i < savedDices.Count(); i++)
                {
                    savedDices[i] = false;
                }
                Rolls = 0;
            }
        }
    }
}
