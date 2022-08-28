using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            
            Console.WriteLine("Original:");
            Console.WriteLine($"p1 = ({p1.x},{p1.y})");
            Console.WriteLine($"p2 = ({p2.x},{p2.y})");

            swapPoints(p1, p2);

            Console.WriteLine("\nSwapped:");
            Console.WriteLine($"p1 = ({p1.x},{p1.y})");
            Console.WriteLine($"p2 = ({p2.x},{p2.y})");
            Console.ReadKey();
        }

        public static void swapPoints(Point p1, Point p2) 
        {
            Point placeHolder = new Point(0, 0);
            placeHolder.x = p2.x;
            placeHolder.y = p2.y;

            p2.x = p1.x;
            p2.y = p1.y;

            p1.x = placeHolder.x;
            p1.y = placeHolder.y;
        }
    }
}
