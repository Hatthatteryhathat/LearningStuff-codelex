using System;
using System.Collections.Generic;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            foreach (string number in cryptedNumbers) 
            {
                foreach (char digit in number) 
                {
                    Console.Write((int)digit);
                }

                Console.WriteLine();
            }

            Console.ReadKey(); 
        }
    }
}
