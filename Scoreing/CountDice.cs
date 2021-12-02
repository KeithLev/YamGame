using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    class CountDice
    {
        public int[] CountOfDice(List<IDice> dice)
        {
            int[] count = new int[6];
            foreach(IDice dice1 in dice)
            {
                int n = ((int)dice1.ReturnCurrentSide()) - 1;
                count[n]++;
            }

            return count;

        }
    }
}
