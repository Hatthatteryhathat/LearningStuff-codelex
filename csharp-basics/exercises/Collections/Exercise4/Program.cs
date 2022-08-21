using System;
using System.Collections.Generic;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            while (true) 
            { 
                Console.Write("Enter name: ");
                string input = Console.ReadLine();

                if (input != "")
                {
                    uniqueNames.Add(input);
                }
                else 
                {
                    break;
                }
            }

            Console.WriteLine("-=-=-=-=-=-=-=-");
            Console.WriteLine($"Unique name list contains: {string.Join(" ", uniqueNames)}");
            Console.ReadKey();
        }
    }
}
