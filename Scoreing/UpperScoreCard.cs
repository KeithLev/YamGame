using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    class UpperScoreCard
    {
        public  int AcesScore;
        public bool CanAddAces;
        public  int TwosScore;
        public bool CanAddTwos;
        public  int ThreesScore;
        public bool CanAddThrees;
        public  int FoursScore;
        public bool CanAddFours;
        public  int FivesScore;
        public bool CanAddFives;
        public  int SixScore;
        public bool CanAddSixes;
        public int Total;

        public UpperScoreCard()
        {
            
            ResetScoreCard();


        }


        public bool AddAces(List<IDice> dice)
        {   
            if (CanAddAces && checkDiceFaceEqual(dice, DiceFace.One))
            {
                AcesScore = dice.Count();
                Total += AcesScore;
                CanAddAces = false;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddTwos(List<IDice> dice)
        {
            if (CanAddTwos && checkDiceFaceEqual(dice, DiceFace.Two))
            {
                TwosScore = dice.Count() * 2;
                Total += TwosScore;
                CanAddTwos = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AddThrees(List<IDice> dice)
        {
            if (CanAddThrees && checkDiceFaceEqual(dice, DiceFace.Three))
            {
                ThreesScore = dice.Count() * 3;
                Total += ThreesScore;
                CanAddThrees = false;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool AddFours(List<IDice> dice)
        {
            if (CanAddFours && checkDiceFaceEqual(dice, DiceFace.Four))
            {
                FoursScore = dice.Count() * 4;
                Total += FoursScore;
                CanAddFours = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddFives(List<IDice> dice)
        {
            if (CanAddFives && checkDiceFaceEqual(dice, DiceFace.Five))
            {
                FivesScore = dice.Count() * 5;
                Total += FivesScore;
                CanAddFives = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddSix(List<IDice> dice)
        {
            if (CanAddSixes && checkDiceFaceEqual(dice, DiceFace.Six))
            {
                SixScore = dice.Count() * 6;
                Total += SixScore;
                CanAddSixes = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkDiceFaceEqual(List<IDice> dice, DiceFace diceFace)
        {
            if (dice.All(c => c.ReturnCurrentSide() == diceFace))
            {
                return true;
            }
            else return false;
        }

        public void ResetScoreCard()
        {
            AcesScore = 0;
            CanAddAces = true;
            TwosScore = 0;
            CanAddTwos = true;
            ThreesScore = 0;
            CanAddThrees = true;
            FoursScore = 0;
            CanAddFours = true;
            FivesScore = 0;
            CanAddFives = true;
            SixScore = 0;
            CanAddSixes = true;
            Total = 0;
        }
    }
}
