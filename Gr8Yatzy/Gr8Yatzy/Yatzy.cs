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
        public int MaxAlloawedPlayers { get; set; }
        public int MinAllowedPlayers { get; set; }
        public List<Dice> Dices { get; set; } // de tärningar som kan kastas
        public List<Dice> SavedDices { get; set; }// lägger de tärningar som sparas i en separat lista


        /// <summary>
        /// Slumpar fram värdet från de tärningar i listan
        /// </summary>
        /// <param name="dices"></param>
        /// <returns></returns>
        public List<Dice> RollDices(List<Dice> dices)
        {

            Random random = new Random();

            foreach (Dice dice in dices)
            {
                dice.Value = random.Next(1, 7);
            }

            return dices;
        }


        /// <summary>
        /// Tar bort de tärningarna som sparas från dices och lägger till den/de tärningar
        /// i en lista med sparade. 
        /// </summary>
        /// <param name="dices"></param>
        /// <returns></returns>
        public List<Dice> SaveDices(List<Dice> dices)// Behöver en funktion för att kunna välja tärning att kastas igen
        {
            foreach (Dice d in dices)
            {
                if (d.IsSaved == true)
                {
                    dices.Remove(d);
                    SavedDices.Add(d);
                }
            }
            return dices;
        }

    }
}
