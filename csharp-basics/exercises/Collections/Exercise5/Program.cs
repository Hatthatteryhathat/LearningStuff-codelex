using System;
using System.Collections.Generic;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check: ");
            Console.WriteLine($"---\nChosen number is : " + HappyOrSad(Console.ReadLine()));

            Console.ReadKey();
        }

        public static string HappyOrSad(string number) 
        { 
            HashSet<double> sumsOfSquares = new HashSet<double>();
            List<char> digits = GetDigits(number);
            double currentSum = 0;

            while (true) 
            {
                foreach (var digit in digits) 
                {
                    currentSum += Math.Pow(char.GetNumericValue(digit), 2);
                }

                Console.Write(String.Join("^2 + ", digits));
                Console.Write("^2 = " + currentSum + "\n");

                if (!sumsOfSquares.Add(currentSum)) 
                {
                    return "not happy :c";
                }

                if (currentSum == 1) 
                {
                    return "happy! :)";
                }

                digits.Clear();
                digits = GetDigits(currentSum.ToString());
                currentSum = 0;
            }
        }

        public static List<char> GetDigits(string number) 
        {
            return new List<char>(number.ToCharArray());
        }
    }
}
