using System;

namespace Exercise2_CheckOddEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = GetNumberToCheck();
            string result = numberToCheck % 2 == 1 ? "Odd Number" : "Even Number";

            Console.WriteLine($"---------\n {result}");
            Console.WriteLine(" bye!");
            Console.ReadKey();
        }

        static int GetNumberToCheck()
        {
            int valueToCheck = 0;
            Console.Write("Enter a number :: \n ");

            while (!int.TryParse(Console.ReadLine(), out valueToCheck))
            {
                Console.Clear();
                Console.WriteLine("You entered an invalid number!");
                Console.Write("Enter a number :: \n ");
            }
            return valueToCheck;
        }
    }
}
