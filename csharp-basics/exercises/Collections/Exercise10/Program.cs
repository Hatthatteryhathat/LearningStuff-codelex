using System;
using System.Collections.Generic;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> values = new HashSet<string>();
            values.Add("Heloo");
            values.Add("Eyoo");
            values.Add("Codelexx");
            values.Add("Programmy stuff");
            values.Add("Bye!");

            Console.WriteLine("Printing sett: ");
            PrintSet(values);

            values.Clear();
            Console.WriteLine("\nPrinting cleared sett: ");
            PrintSet(values);

            values.Add("Intense programmy stuff");
            values.Add("Intense programmy stuff");
            values.Add("Intense programmy stuff");
            values.Add("Intense programmy stuff");
            Console.WriteLine("\nPrinting set after attempting to add duplicates: ");
            PrintSet(values);

            Console.ReadKey();
        }

        public static void PrintSet(HashSet<string> values) 
        {
            foreach (var value in values)
            {
                Console.WriteLine($"> {value}");
            }
        }
    }
}
