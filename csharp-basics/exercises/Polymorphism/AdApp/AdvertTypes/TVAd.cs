namespace AdApp.AdvertTypes
{
    public class TVAd : Advert
    {
        private int _airTime;
        private int _ratePerSecond;
        private bool _isPeakTime;

        public TVAd(int fee, int airTime, int ratePerSecond, bool isPeakTime) : base(fee)
        {
            _airTime = airTime;
            _ratePerSecond = ratePerSecond;
            _isPeakTime = isPeakTime;
        }

        public new int Cost()
        {
            var fee = base.Cost();
            var peakCostIncrease = _isPeakTime ? 1.5 : 1;
            return (int)(fee + _airTime * _ratePerSecond * peakCostIncrease);
        }

        public override string ToString()
        {
            var info = "\nTVAd" + base.ToString().Substring(7);
            info += "\nTotal airtime in seconds: " + _airTime;
            info += "\nRate per second: $" + _ratePerSecond;
            info += "\nIs peakTime: " + _isPeakTime;
            return info;
        }
    }
}