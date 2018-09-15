using System;
using System.Linq;

namespace Gr8Yatzy
{
    class YatzyRules
    {
        public Player ValidateYatzyRule(/*int[] dices*/)
        {
            Player p = new Player() { NickName = "w00t", PlayerProtocol = new Protocol() };
            string aligbleRows;
            int temp = 0;
            int temp2 = 0;
            int temp3 = 0;
            int temp4 = 0;
            int test = 0;
            int[] dices = { 2, 5, 5, 2, 5 };
            Array.Sort(dices);

            for (int i = 0; i < dices.Length; i++)
            {
                if (i < dices.Length - 1)
                {
                    switch (i)
                    {
                        case 0:
                            if (dices[0] == dices[1])
                            {
                                temp = dices[0];

                                if (dices[2] == dices[3] && dices[3] == dices[4] && dices[2] != temp)
                                {
                                    p.PlayerProtocol.IsFullHouse = true;
                                    p.PlayerProtocol.IsThreeOfAKind = true;
                                }

                                if (temp == dices[2])
                                {
                                    temp2 = dices[2];
                                    p.PlayerProtocol.IsFourOfAKind = true;

                                    if (temp2 == dices[4])
                                    {
                                        p.PlayerProtocol.IsYatzy = true;
                                    }
                                }

                                if (dices[2] == dices[3] && dices[2] != temp)
                                {
                                    p.PlayerProtocol.IsTwoPair = true;
                                }
                            }
                            return p;

                        //case 1:
                        //    if (dices[0] == dices[1] && dices[0] == dices[2])
                        //    {
                        //        temp2 = dices[0];

                        //        if (temp2 == dices[3])
                        //        {
                        //            p.PlayerProtocol.IsFourOfAKind = true;
                        //        }
                        //        return p.PlayerProtocol.IsThreeOfAKind = true;
                        //    }

                        default:
                            break;
                    }

                }
            }


            throw new Exception("Det finns inga kombinationer som du kan spara");
        }
    }
}
