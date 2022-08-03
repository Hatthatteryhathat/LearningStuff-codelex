using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadKey();
            
            if (char.GetNumericValue(input.KeyChar) > 0)
            {
                Console.WriteLine("\nNumber is positive");
            } 
            else if (char.GetNumericValue(input.KeyChar) < 0) 
            {
                Console.WriteLine("\nNumber is negative");
            } 
            else 
            {
                Console.WriteLine("\nNumber is zero");
            }
            
            Console.ReadKey();
        }
    }
}
