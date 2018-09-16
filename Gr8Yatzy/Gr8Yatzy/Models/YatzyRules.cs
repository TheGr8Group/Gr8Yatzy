using System;
using System.Linq;

namespace Gr8Yatzy
{
    class YatzyRules
    {
        public Player ValidateYatzyRule(/*int[] dices*/)
        {
            Player p = new Player() { NickName = "w00t", PlayerProtocol = new Protocol() };//För test

            int temp = 0;
            int temp2 = 0;

            int[] dices = { 2, 3, 4, 5, 6 };
            Array.Sort(dices);

            for (int i = 0; i < dices.Count(); i++)
            {
                if (i < dices.Count() - 1)
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
                            break;
                    }
                }

                switch (i)
                {
                    case 0:
                        if (i < 1)
                        {

                            int nrOfLoop = dices.Count() - 1;
                            int isSmallStraight = 0;//För test

                            if (dices[0] == 1)
                            {
                                for (int j = 0; j < dices.Count(); j++)
                                {
                                    for (int k = nrOfLoop; k < dices.Count(); k++)
                                    {
                                        if (dices[j] < dices[k])
                                        {
                                            p.PlayerProtocol.IsSmallStraight = true;

                                        }
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                switch (i)
                {

                    case 0:
                        if (i < 1)
                        {

                            int nrOfLoop = dices.Count() - 1;
                            int isLargeStraight = 0;//Test 

                            if (dices[0] == 2)
                            {
                                for (int j = 0; j < dices.Count(); j++)
                                {
                                    for (int k = nrOfLoop; k < dices.Count(); k++)
                                    {
                                        if (dices[j] < dices[k])
                                        {
                                            p.PlayerProtocol.IsLargeStraight = true;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }

                switch (i)
                {
                    case 0:
                        for (int j = 0; j < dices.Count(); j++)
                        {
                            if (dices[j] == 1)
                            {
                                p.PlayerProtocol.IsOnes = true;
                            }

                            if (dices[j] == 2)
                            {
                                p.PlayerProtocol.IsTwos = true;
                            }

                            if (dices[j] == 3)
                            {
                                p.PlayerProtocol.IsThrees = true;
                            }

                            if (dices[j] == 4)
                            {
                                p.PlayerProtocol.IsFours = true;
                            }

                            if (dices[j] == 5)
                            {
                                p.PlayerProtocol.IsFives = true;
                            }

                            if (dices[j] == 6)
                            {
                                p.PlayerProtocol.IsSixes = true;
                            }
                        }
                        break;
                }
            }
            return p;
        }
    }
}
