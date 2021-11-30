using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    interface IPlayer
    {
        void AddToScore(int score);
        int ReturnScore();
        List<IDice> RollAllDice();

        List<IDice> RollSelectedDice(List<IDice> selectedDice);
        List<IDice> ReturnCurrentDice();

        void ResetScore();



    }
}
