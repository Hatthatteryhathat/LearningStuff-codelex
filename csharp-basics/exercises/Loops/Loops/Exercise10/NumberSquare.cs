using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class NumberSquare
    {
        public void DrawNumberSquare() 
        {
            Console.Write("Min ? :");
            int min = Int32.Parse(Console.ReadLine());
            Console.Write("Max ? :");
            int max = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            string numberString = "";

            for (int i = min; i <= max; i++) 
            {
                numberString += i.ToString();
            }

            for (int i = min; i <= max; i++) 
            {
                Console.WriteLine(numberString);
                numberString = numberString.Substring(1, numberString.Length - 1) + numberString.Substring(0, 1);
            }
        }
    }
}
