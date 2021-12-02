using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    class ScoreCard : IScoreCard
    {
        public int GameTotal;
        UpperScoreCard upperScoreCard;
        LowerScoreCard lowerScoreCard;

        public ScoreCard()
        {
            GameTotal = 0;
            upperScoreCard = new UpperScoreCard();
            lowerScoreCard = new LowerScoreCard();
        }

        private int UpperScoreCardPlusBonus()
        {
            int newTotal;
            if (upperScoreCard.Total >= 63)
            {
                newTotal = upperScoreCard.Total + 35;
                return newTotal;
            }
            else return upperScoreCard.Total;
        }


        public int CalculateTotal()
        {
            GameTotal = UpperScoreCardPlusBonus() + lowerScoreCard.Total;
            return GameTotal;

        }

        public void ResetScoreCard()
        {
            GameTotal = 0;
            upperScoreCard.ResetScoreCard();
            lowerScoreCard.ResetScoreCard();
        }
    }
}
