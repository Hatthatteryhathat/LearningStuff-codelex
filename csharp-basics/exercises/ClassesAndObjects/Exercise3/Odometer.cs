using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Odometer
    {
        private double _currentMileage;
        private double _counter = 0;

        public Odometer(double initialMilage)
        {
            _currentMileage = initialMilage;
        }

        public double GetMileage()
        {
            return _currentMileage;
        }
        
        public void AddMileage(FuelGauge fuelGauge)
        {
            _currentMileage++;
            _counter++;

            if (_currentMileage > 999999) 
            {
                _currentMileage = 0;
            }

            if (_counter == 10) 
            {
                BurnFuel(fuelGauge);
                _counter = 0;
            }
        }

        private void BurnFuel(FuelGauge fuelGauge)
        {
            fuelGauge.RemoveFuel();
        }
    }
}
