using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                int input = GetMenuInput();
                Console.WriteLine("\n<====================>");
                switch (input)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3:
                        CalculateTriangleArea();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("\n Press any key to continnue: ");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static int GetMenuInput()
        {
            DisplayMenu();

            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (char.IsDigit(userInput.KeyChar)) 
                {
                    return (int)char.GetNumericValue(userInput.KeyChar);
                }
            }
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            int radius = Int32.Parse(Console.ReadLine());

            Console.WriteLine("The circle's area is "
                    + Math.Round(Geometry.AreaOfCircle(radius), 2));
        }

        public static void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            decimal length = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter width? ");
            decimal width = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Math.Round(Geometry.AreaOfRectangle(length, width), 2));
        }

        public static void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base? ");
            decimal ground = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter triangle's height? ");
            decimal height = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The triangle's area is "
                    + Math.Round(Geometry.AreaOfRectangle(ground, height), 2));
        }

        public static void DisplayMenu() 
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.Write("Enter your choice (1-4) : ");
        }
    }
}
