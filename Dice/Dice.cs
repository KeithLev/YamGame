using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    public class Dice : IDice
    {
        private DiceFace currentDiceFace;

        public Dice()
        {
            currentDiceFace = RollDice();
            
        }

        public DiceFace ReturnCurrentSide()
        {
            return currentDiceFace;
        }

        public DiceFace RollDice()
        {
            
            currentDiceFace = (DiceFace)Randomiser.random.Next(1,6);
            return currentDiceFace;
        }
    }
}
