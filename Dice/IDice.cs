using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    public interface IDice
    {
        DiceFace RollDice();
        DiceFace ReturnCurrentSide();
    }
}
