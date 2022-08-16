using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 1000;
            int century = year / 100; ;

            if ((year % 100) != 0) 
            {
                century += 1;
            }

            Console.WriteLine($"{century}{(century == 21? "st" : "th")} century");
            Console.ReadKey();
        }
    }
}
