using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valToTest = GetUserValues();
            if ((valToTest[0] == 15 || valToTest[1] == 15) || Math.Abs(valToTest[0] + valToTest[1]) == 15)
            {
                Console.WriteLine("--------- \n true");
            }
            else 
            {
                Console.WriteLine("--------- \n false");
            }

            Console.ReadKey();
        }

        static int[] GetUserValues()
        {
            int[] bothValues = {0, 0};
            Console.Write("Enter 2 numbers to test::\n");

            for (int i = 0; i < 2; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out bothValues[i]))
                {
                    Console.WriteLine("How did you mess this up?! Enter a valid number!");
                }
            }

            return bothValues;
        }
    }
}
