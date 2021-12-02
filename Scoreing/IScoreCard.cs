using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    public interface IScoreCard
    {
        int CalculateTotal();
        void ResetScoreCard();

    }
}
