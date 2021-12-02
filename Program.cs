using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            BasicActions basicActions = new BasicActions();
            ScoreCard scoreCard = new ScoreCard();
            List<IDice> dice = new List<IDice>();

            int round = 0;
            int rolls = 0;


            for(int i = 0; i <= 4; i++)
            {
                Dice dice1 = new Dice();
                dice.Add(dice1);
            }
            while(round <= 13)
            {
                Console.WriteLine("These are you dice:");
                basicActions.PrintDice(dice);
                Console.WriteLine("Select dice to reroll");
                string selectedDice = Console.ReadLine();
                List<IDice> selected = basicActions.SelectedDice(dice, selectedDice);
                basicActions.RollDice(selected);
                Console.WriteLine($"Your rerolled dice are:");
                basicActions.PrintDice(selected);
                Console.ReadLine();






            }



            
            






        }





    }
}
