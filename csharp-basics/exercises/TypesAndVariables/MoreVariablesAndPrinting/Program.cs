using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Zed A. Shaw";
            string Eyes = "Blue";
            string Teeth = "White";
            string Hair = "Brown";
            int Age = 35;
            double Height = Math.Round(CmToInches(74), 2);
            double Weight = Math.Round(KgToPounds(180), 2);

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " inches tall.");
            Console.WriteLine("He's " + Weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + Age + ", " + Height + ", and " + Weight
                               + " I get " + (Age + Height + Weight) + ".");

            Console.ReadKey();
        }
        static double CmToInches(double lengthInCm) 
        {
            return lengthInCm / 2.54;
        }
        static double KgToPounds(double weightInKg)
        {
            return weightInKg / 0.453592;
        }
    }
}