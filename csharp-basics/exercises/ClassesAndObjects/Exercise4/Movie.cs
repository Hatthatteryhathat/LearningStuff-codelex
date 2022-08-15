using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Movie
    {
        public string title;
        public string studio;
        public string rating;

        public Movie(string movieTitle, string movieStudio, string movieRating)
        {
            title = movieTitle;
            studio = movieStudio;
            rating = movieRating;
        }

        public Movie(string movieTitle, string movieStudio) 
        {
            title = movieTitle;
            studio = movieStudio;
            rating = "PG";
        }

        public void DisplayMovie() 
        {
            Console.WriteLine(title);
            Console.WriteLine(studio);
            Console.WriteLine(rating);
            Console.WriteLine("-=-=-=-=-=-=-=-");
        }
    }
}
