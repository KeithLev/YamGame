using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    interface IDice
    {
        DiceFace RollDice();
        DiceFace ReturnCurrentSide();
    }
}
