using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class FuelGauge
    {
        private double _currentFuel = 0;

        public double GetFuel() 
        { 
            return _currentFuel;
        }

        public void AddFuel() 
        {
            _currentFuel++;
        }

        public void RemoveFuel()
        {
            _currentFuel--;
        }
    }
}
