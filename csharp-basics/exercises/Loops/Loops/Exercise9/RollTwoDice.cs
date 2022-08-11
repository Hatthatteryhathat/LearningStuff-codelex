using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    internal class RollTwoDice
    {
        public void DiceGame() 
        {
            int desiredSum = 2;
            Random rnd = new Random();
            int dice1 = 1;
            int dice2 = 2;
            int sum = 0;

            while (true)
            { 
                Console.Write("Desired sum : ");
                desiredSum = Int32.Parse(Console.ReadLine());

                if (desiredSum > 1 && desiredSum < 13) 
                {
                    break;
                }

                Console.WriteLine("Chosen sum can not be achieved with 2 d6 dice!");
            }

            while (true) 
            { 
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);
                sum = dice1 + dice2;

                Console.WriteLine($"{dice1} and {dice2} = {sum}");

                if (sum == desiredSum) 
                {
                    break;
                }
            }
        }
    }
}
