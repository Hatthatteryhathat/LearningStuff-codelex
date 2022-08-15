namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startOdometerReading;
        private double _currentOdometerReading;
        private double _litersSpent;

        public Car(double startOdo)
        {
            _startOdometerReading = startOdo;
            _currentOdometerReading = startOdo;
            _litersSpent = 1;
        }

        public double CalculateConsumption() // km per 1l
        {
            return ( _currentOdometerReading - _startOdometerReading) / _litersSpent;
        }

        private double ConsumptionPer100Km() // l per 100km
        {
            return ( _litersSpent * 100) / ( _currentOdometerReading - _startOdometerReading );
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }
        
        public void FillUp(double currentOdometerReading, double litersSpent)
        {
            _currentOdometerReading = currentOdometerReading;
            _litersSpent = litersSpent;
        }
    }
}
