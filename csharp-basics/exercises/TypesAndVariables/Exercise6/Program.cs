using System;
using System.Linq;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfDigitsToSum = GetAmountOfDigitsToSum();
            int[] digitsToSum = GetDigitsToSum(amountOfDigitsToSum);
            
            Console.WriteLine($"---\nAnd the sum is! ::: {digitsToSum.Sum()}");
            Console.ReadKey();
        }

        static int GetAmountOfDigitsToSum() 
        {
            int inputAmount;
            Console.Write("Enter the amount of single digit numbers you'd like to sum!:  ");

            while (!int.TryParse(Console.ReadLine(), out inputAmount))
            {
                Console.Clear();
                Console.WriteLine("You entered an invalid number!");
                Console.Write("Enter the amount of single digit numbers you'd like to sum!:  ");
            }
            return inputAmount;
        }

        static int[] GetDigitsToSum(int amountToSum) 
        {
            int[] allDigits = {};
            Console.Write($"Enter {amountToSum} single digit numbers:\n");

            for (int i = 1; i <= amountToSum; i++)
            {
                Array.Resize(ref allDigits, allDigits.Length + 1);
                while (!int.TryParse(Console.ReadLine(), out allDigits[allDigits.GetUpperBound(0)]))
                {
                    Console.WriteLine("How did you mess this up?! Enter a valid number!");
                }
            }
            return allDigits;
        }
    }
}
