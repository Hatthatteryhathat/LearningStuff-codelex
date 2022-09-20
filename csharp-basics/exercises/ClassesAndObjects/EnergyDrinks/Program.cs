using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class Program
    {
        private const int _NumberedSurveyed = 12467;
        private const double _PurchasedEnergyDrinks = 0.14;
        private const double _PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            double energyDrinkers = CalculateEnergyDrinkers(_NumberedSurveyed , _PurchasedEnergyDrinks);
            double preferCitrus = CalculatePreferCitrus(energyDrinkers , _PurchasedEnergyDrinks);

            Console.WriteLine("Total number of people surveyed " + _NumberedSurveyed + "!");
            Console.WriteLine("Approximately " + Math.Round(energyDrinkers, 2) + " bought at least one energy drink!");
            Console.WriteLine(Math.Round(preferCitrus, 2) + " of those " + "prefer citrus flavored energy drinks!");
            Console.ReadKey();
        }

        public static double CalculateEnergyDrinkers(int numberSurveyed, double boughtEDrinks)
        {
            return numberSurveyed * boughtEDrinks;
        }

        public static double CalculatePreferCitrus(double energyDrinkers, double preferCitrus)
        {
            return energyDrinkers * preferCitrus;
        }
    }
}
