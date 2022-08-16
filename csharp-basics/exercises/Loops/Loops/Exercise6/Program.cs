using System;

namespace Exercise6
{
    internal class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Enter max value :: ");
            int endPoint = Int32.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= endPoint; i++) 
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }

                counter++;

                if (counter == 20) 
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
