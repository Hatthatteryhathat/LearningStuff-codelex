using System;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of day :: ");
            string day = Console.ReadLine();
            int num;

            if (Int32.TryParse(day, out num))
            {
                if (num > 0)
                {
                    switch (day)
                    {
                        case "0":
                            Console.WriteLine("Monday");
                            break;
                        case "1":
                            Console.WriteLine("Tuesday");
                            break;
                        case "2":
                            Console.WriteLine("Wednesday");
                            break;
                        case "3":
                            Console.WriteLine("Thursday");
                            break;
                        case "4":
                            Console.WriteLine("Friday");
                            break;
                        case "5":
                            Console.WriteLine("Saturday");
                            break;
                        case "6":
                            Console.WriteLine("Sunday");
                            break;
                        default:
                            Console.WriteLine("Not a valid day");
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Input value can not be negative!");
                }
            }
            else 
            { 
                Console.WriteLine("Input value is not a number!");
            }

            Console.ReadKey();
        }
    }
}
