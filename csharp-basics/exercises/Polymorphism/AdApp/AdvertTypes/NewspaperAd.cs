namespace AdApp.AdvertTypes
{
    public class NewspaperAd : Advert
    {
        private int _columnInCm;
        private int _ratePerCm;

        public NewspaperAd(int fee, int column, int rate) : base(fee)
        {
            _columnInCm = column;
            _ratePerCm = rate;
        }

        private new int Cost()
        {
            var fee = base.Cost();
            return fee + _columnInCm * _ratePerCm;
        }

        public override string ToString()
        {
            var info = "\nNewsPaperAd" + base.ToString().Substring(7);
            info += "\nColumns in cm: " + _columnInCm;
            info += "\nRate per cm: $" + _ratePerCm;
            return info;
        }
    }
}