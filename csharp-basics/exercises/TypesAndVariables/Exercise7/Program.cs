using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:: ");
            string userInputString = Console.ReadLine();

            int amountOfUpperLetters = 0;
            foreach (char chr in userInputString)
            {
                if (Char.IsUpper(chr)) 
                {
                    amountOfUpperLetters++;
                }
            }

            Console.WriteLine($"---\n Amount of uppercase letters is ::: {amountOfUpperLetters}");
            Console.ReadKey();
        }
    }
}
