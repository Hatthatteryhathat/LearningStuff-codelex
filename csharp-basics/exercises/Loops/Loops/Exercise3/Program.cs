using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 20; i++) 
            {
                numberList.Add(rnd.Next(-100,100));
            }

            Console.WriteLine("Which number position out of 20 random numbers you want to know?");
            int position = Int32.Parse(Console.ReadLine());

            Console.WriteLine("-=-=-=");
            Console.WriteLine($"At posittion {position} the number is :: {numberList[position - 1]}");
            Console.WriteLine(string.Join(", ", numberList));
            Console.ReadKey();
        }
    }
}
