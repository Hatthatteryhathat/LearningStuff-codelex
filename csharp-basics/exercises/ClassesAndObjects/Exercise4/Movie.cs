using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Movie
    {
        private string _title;
        private string _studio;
        private string _rating;

        public Movie(string movieTitle, string movieStudio, string movieRating)
        {
            _title = movieTitle;
            _studio = movieStudio;
            _rating = movieRating;
        }

        public Movie(string movieTitle, string movieStudio) 
        {
            _title = movieTitle;
            _studio = movieStudio;
            _rating = "PG";
        }

        public void DisplayMovie() 
        {
            Console.WriteLine(_title);
            Console.WriteLine(_studio);
            Console.WriteLine(_rating);
            Console.WriteLine("-=-=-=-=-=-=-=-");
        }

        public string Rating => _rating;
    }
}
