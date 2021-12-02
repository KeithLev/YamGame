using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    class LowerScoreCard
    {
        public int ThreeOfAKindScore;
        public bool CanAddThreeOfAKind;
        public int FourOfAKindScore;
        public bool CanAddFourOfAKind;
        public int FullHouseScore;
        public bool CanAddFullHouse;
        public int SmallStraightScore;
        public bool CanAddSmallStraight;
        public int LargeStraightScore;
        public bool CanAddLargeStraight;
        public int ChanceScore;
        public bool CanAddChance;
        public int YahtzeeScore;
        public bool CanAddYahtzee;
        public int Total;
        CountDice countDice;
        

        public LowerScoreCard()
        {
            ResetScoreCard();
            countDice = new CountDice();
        }

        public bool AddThreeOfAKind(List<IDice> dice)
        {
            //convert dice into a int array counting how many of each face are present
            int[] diceInt = countDice.CountOfDice(dice);

            // check there are 3 of a kind
            if (diceInt.Any(d => d == 3) && CanAddThreeOfAKind)
            {
                int diceTotal = 0;
                foreach (IDice dice1 in dice)
                {
                    diceTotal += (int)dice1.ReturnCurrentSide();
                }
                ThreeOfAKindScore = diceTotal;
                Total += ThreeOfAKindScore;
                CanAddThreeOfAKind = false;
                return true;
            }

            else return false;
        }

        public bool AddFourOfAKind(List<IDice> dice)
        {
            //convert dice into a int array counting how many of each face are present
            int[] diceInt = countDice.CountOfDice(dice);

            //check there are 4 of a kind
            if (diceInt.Any(d => d == 4) && CanAddFourOfAKind)
            {
                int diceTotal = 0;
                foreach (IDice dice1 in dice)
                {
                    diceTotal += (int)dice1.ReturnCurrentSide();
                }
                FourOfAKindScore = diceTotal;
                Total += FourOfAKindScore;
                CanAddFourOfAKind = false;
                return true;
            }

            else return false;
        }

        public bool AddFullHouse(List<IDice> dice)
        {
            //convert dice into a int array counting how many of each face are present
            int[] diceInt = countDice.CountOfDice(dice);

            //check there are 3 of a kind and 4 of a kind
            if (diceInt.Any(d => d == 3) && diceInt.Any(d => d == 2) && CanAddFullHouse)
            {
                FullHouseScore = 25;
                Total += FullHouseScore;
                CanAddFullHouse = false;
                return true;
            }

            else return false;


        }

        public bool AddSmallStraight(List<IDice> dice)
        {
            if ((IfFourNumbers(dice, 1, 2, 3, 4) || IfFourNumbers(dice, 2, 3, 4, 5) || IfFourNumbers(dice, 3, 4, 5, 6)) && CanAddSmallStraight)
            {
                SmallStraightScore = 30;
                Total += SmallStraightScore;
                CanAddSmallStraight = false;
                return true;
            }
            else return false;
        }

        public bool AddLargeStraight(List<IDice> dice)
        {
            int[] intDice = countDice.CountOfDice(dice);
            if (intDice.All(d => d == 1) && CanAddLargeStraight)
            {
                LargeStraightScore = 40;
                Total += LargeStraightScore;
                CanAddLargeStraight = false;
                return true;
            }

            else return false;
        }

        public bool AddChance(List<IDice> dice)
        {
            if (CanAddChance)
            {
                int diceTotal = 0;
                foreach (Dice dice1 in dice)
                {
                    diceTotal += (int)dice1.ReturnCurrentSide();
                }
                ChanceScore = diceTotal;
                Total += ChanceScore;
                CanAddChance = false;
                return true;
            }
            else return false;
        }


        public bool AddYahtzee(List<IDice> dice)
        {
            int[] intDice = countDice.CountOfDice(dice);
            if (intDice.Any(d => d == 5) && CanAddYahtzee)
            {
                YahtzeeScore = 50;
                Total += YahtzeeScore;
                CanAddYahtzee = false;
                return true;

            }

            else return false;
        }




        public void ResetScoreCard()
        {
            ThreeOfAKindScore = 0;
            CanAddThreeOfAKind = true;
            FourOfAKindScore = 0;
            CanAddFourOfAKind = true;
            FullHouseScore = 0;
            CanAddFullHouse = true;
            SmallStraightScore = 0;
            CanAddSmallStraight = true;
            LargeStraightScore = 0;
            CanAddLargeStraight = true;
            ChanceScore = 0;
            CanAddChance = true;
            YahtzeeScore = 0;
            CanAddYahtzee = true;
            Total = 0;
        }

        private bool IfAny(List<IDice> dice, int i)
        {
            if (dice.Any(d => (int)d.ReturnCurrentSide() == i))
            {
                return true;
            }
            else return false;
        }

        private bool IfFourNumbers(List<IDice> dice, int a, int b, int c, int d)
        {
            if (IfAny(dice, a) && IfAny(dice, b) && IfAny(dice, c) && IfAny(dice, d))
            {
                return true;
            }
            else return false;

        }
    }
}
