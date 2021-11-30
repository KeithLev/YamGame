using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    class Player : IPlayer
    {
        private List<IDice> dice;
        private int score;

        public Player(List<IDice> dice)
        {
            this.score = 0;
            this.dice = dice;

        }

        public void AddToScore(int score)
        {
            this.score += score;
        }

        public void ResetScore()
        {
            this.score = 0;
        }

        public List<IDice> ReturnCurrentDice()
        {
            return this.dice;
        }

        public int ReturnScore()
        {
            return this.score;
        }

        public List<IDice> RollAllDice()
        {
            foreach(IDice dice1 in dice)
            {
                dice1.RollDice();
            }
            return this.dice;
        }

        public List<IDice> RollSelectedDice(List<IDice> selectedDice)
        {
            foreach(IDice dice in selectedDice)
            {
                dice.RollDice();
            }
            return selectedDice;

        }
    }
}
