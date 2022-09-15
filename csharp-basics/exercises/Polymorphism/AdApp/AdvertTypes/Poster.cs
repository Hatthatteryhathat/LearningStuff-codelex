using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp.AdvertTypes
{
    internal class Poster : Advert
    {
        private int _dimensionX;
        private int _dimensionY;
        private int _numOfCopyes;
        private int _costPerCoppy;

        public Poster(int fee,int dimensionX, int dimensionY, int numOfCopyes, int costPerCoppy) : base(fee)
        {
            _dimensionX = dimensionX;
            _dimensionY = dimensionY;
            _numOfCopyes = numOfCopyes;
            _costPerCoppy = (int)(costPerCoppy + (dimensionX * dimensionY * 0.0002));
        }

        public new int Cost()
        {
            var fee = base.Cost();
            return (int)(fee + _numOfCopyes * _costPerCoppy);
        }

        public override string ToString()
        {
            var info = "\nPoster" + base.ToString().Substring(7);
            info += "\nPosterDimensionX: " + _dimensionX + " cm";
            info += "\nPosterDimensionY: " + _dimensionY + " cm";
            info += "\nNumber of posters: " + _numOfCopyes;
            info += "\nCost per poster: $" + _costPerCoppy;
            return info;
        }
    }
}
