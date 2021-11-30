using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YamGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDice> dice = new List<IDice>();
            for(int i = 0; i < 6; i++)
            {
                Dice dice1 = new Dice();
                dice.Add(dice1);
            }

            Player player = new Player(dice);

            List<IDice> dice2 = player.ReturnCurrentDice();
            List<IDice> dice3 = new List<IDice>();
            dice3.Add(dice2[0]);

            foreach (IDice dice1 in dice2)
            {
                Console.WriteLine(dice1.ReturnCurrentSide());
            }
            Console.ReadLine();


            Console.WriteLine(player.RollSelectedDice(dice3)[0].ReturnCurrentSide());

            Console.ReadLine();

            foreach (IDice dice1 in dice2)
            {
                Console.WriteLine(dice1.ReturnCurrentSide());
            }
            Console.ReadLine();




            /*foreach(IDice dice1 in dice2)
            {
                Console.WriteLine(dice1.ReturnCurrentSide());
            }
            Console.ReadLine();

            dice2 = player.RollAllDice();

            foreach (IDice dice1 in dice2)
            {
                Console.WriteLine(dice1.ReturnCurrentSide());
            }
            Console.ReadLine(); */
        }
    }
}
