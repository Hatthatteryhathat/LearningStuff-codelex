using System;
using System.Collections.Generic;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>();

            movieList.Add(new Movie("Casino Royale", "Eon Productions", "PG13"));
            movieList.Add(new Movie("Glass", "Buena Vista International", "PG13"));
            movieList.Add(new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG"));

            List<Movie> pgMovies = GetPG(movieList);

            foreach (Movie movie in pgMovies) 
            {
                movie.DisplayMovie();
            }
            
            Console.ReadLine();
        }

        public static List<Movie> GetPG(List<Movie> movieList) 
        {
            List<Movie> pgMovies = new List<Movie>();

            for (int i = 0; i < movieList.Count; i++) 
            {
                if (movieList[i].Rating == "PG") 
                { 
                pgMovies.Add(movieList[i]);
                }
            }

            return pgMovies;
        } 
    }
}
