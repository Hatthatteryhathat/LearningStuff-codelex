namespace AdApp.AdvertTypes
{
    public class Hoarding : Advert
    {
        private double _ratePerDay;
        private int _numDays;
        private bool _isPrimeLocation;

        public Hoarding(int fee, int days, int rate, bool isPrimeLocation) : base(fee)
        {
            _ratePerDay = rate;
            _numDays = days;
            _isPrimeLocation = isPrimeLocation;
        }

        public new int Cost()
        {
            var surcharge = _isPrimeLocation ? 1.5 : 1;
            return (int)(base.Cost() + _ratePerDay * _numDays * surcharge);
        }

        public override string ToString()
        {
            var info = "\nHoarding" + base.ToString().Substring(7);
            info += "\nNumber of days: " + _numDays;
            info += "\nDaily rate: $" + _ratePerDay;

            return info;
        }
    }
}