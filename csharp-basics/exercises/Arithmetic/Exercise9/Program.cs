using System;

namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heightInInches = 70.0;
            double weightInPounds = 136.6;
            const double bodyMassIndexConstant = 703;
            double bodyMassIndex = (weightInPounds * bodyMassIndexConstant) / (heightInInches * heightInInches);

            Console.WriteLine( "Your BMI is :: " + Math.Round(bodyMassIndex, 2));
            if (bodyMassIndex >= 18.5 && bodyMassIndex <= 25)
            {
                Console.WriteLine("Congrats! Your BMI is optimal!");
            } 
            else if (bodyMassIndex < 18.5) 
            {
                Console.WriteLine("Oh no! You're underweight!");
            }
            else 
            {
                Console.WriteLine("Oh no! You're overweight!");
            }

            Console.ReadKey();
        }
    }
}
