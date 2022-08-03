using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToTest = 132;
            char[] splitDigits = numberToTest.ToString().ToCharArray();
            int sumOfSplitDigits = 0;

            for (int i = 0; i < splitDigits.Length; i++) 
            {
                sumOfSplitDigits += (int)char.GetNumericValue(splitDigits[i]);
            }

            if (numberToTest % sumOfSplitDigits == 0)
            {
                if (TestIfPrime(numberToTest / sumOfSplitDigits))
                {
                    Console.WriteLine("M");
                }
                else 
                {
                    Console.WriteLine("H");
                }
            }
            else 
            {
                Console.WriteLine("Neither");
            }
            
            Console.ReadKey();
        }

        public static bool TestIfPrime(int number) 
        {
            int  halfOfNumber = 0;
            halfOfNumber = number / 2;

            for (int i = 2; i <= halfOfNumber; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
