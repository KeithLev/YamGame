using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    class BasicActions
    {
        public void RollDice(List<IDice> dice)
        {
            foreach (Dice dice1 in dice)
            {
                dice1.RollDice();
            }
        }
        public void PrintDice(List<IDice> dice)
        {
            foreach (Dice dice1 in dice)
            {
                Console.WriteLine(dice1.ReturnCurrentSide());
            }
        }

        public List<IDice> SelectedDice(List<IDice> dice, string whichDice)
        {
            List<IDice> returnDice = new List<IDice>();
            foreach (char c in whichDice)
            {

                returnDice.Add(dice[int.Parse(c.ToString())-1]);
            }
            return returnDice;
        }
    }
}
