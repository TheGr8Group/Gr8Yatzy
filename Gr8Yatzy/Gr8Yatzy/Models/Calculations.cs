using System;
using System.Linq;

namespace Gr8Yatzy
{
    class Calculations
    {
        Protocol proto = new Protocol();

        public void SetPointUpperHalf(int[] dices, YatzyRow row)
        {
            int result = 0;
            
            for (int i = 0; i < dices.Count(); i++)
            {
                if (i == Convert.ToInt32(row))
                {
                    result += i;
                }
            }
            proto.SetRowPoints(result, row);

           
        }
    }
}
