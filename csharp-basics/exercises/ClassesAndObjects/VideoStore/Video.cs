using System;
using System.Linq;
using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isChecked;
        private List<double> _ratingHistory = new List<double>();

        public Video(string title)
        {
            _title = title;
            _isChecked = false;
        }

        public void BeingCheckedOut()
        {
            _isChecked = true;
        }

        public void BeingReturned()
        {
            _isChecked = false;
        }

        public void ReceivingRating(double rating)
        {
            _ratingHistory.Add(rating);
        }

        public double AverageRating()
        {
            return _ratingHistory.Count > 0 ? _ratingHistory.Average() : 0.0;
        }

        public bool Available()
        {
            return !_isChecked;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} {Math.Round(AverageRating(), 1)} {Available()}";
        }
    }
}
