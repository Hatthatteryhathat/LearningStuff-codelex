using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new List<int>();

            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }
            
            var sortedNumbers = new List<int>();

            foreach (int number in numbers) 
            {
                if (number > 30 && number < 100) 
                { 
                    sortedNumbers.Add(number);
                }
            }

            Console.WriteLine(String.Join(", ", sortedNumbers));

            Console.ReadKey();
        }
    }
}
