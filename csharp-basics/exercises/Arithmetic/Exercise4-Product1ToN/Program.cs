using System;

namespace Exercise4_Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToFactor = 10;
            int result = GetFactor(numberToFactor);

            Console.WriteLine("Result is :: " + result);
            Console.ReadKey();
        }

        static int GetFactor(int valueToFactor)
        {
            if (valueToFactor == 1)
            {
                return 1;
            }
            else
            {
                return valueToFactor * GetFactor(valueToFactor - 1);
            }
        }
    }
}
