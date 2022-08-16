using System;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "I am finding Nemo !";
            string[] words = text.Split(" ");
            bool isNemoFound = false;

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Nemo") 
                {
                    Console.WriteLine($"I found Nemo at {i + 1} !!");
                    isNemoFound = true;
                }
            }

            if (!isNemoFound) 
            {
                Console.WriteLine("I can't find Nemo :(");
            }

            Console.ReadKey();
        }
    }
}
