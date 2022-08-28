using System;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date day1 = new Date(1970, 9, 21);
            Date day2 = new Date(1945, 9, 2);
            Date day3 = new Date(2001, 9, 11);

            Console.WriteLine(day1.WeekdayInDutch());
            Console.WriteLine(day2.WeekdayInDutch());
            Console.WriteLine(day3.WeekdayInDutch());

            Console.ReadKey();
        }
    }
}
