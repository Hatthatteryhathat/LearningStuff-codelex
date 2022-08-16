using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program
    {
        private const int _CountOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();

        private static void Main(string[] args)
        {
            bool test = true;
            if (test) 
            {
                TestVideoStore();
                Environment.Exit(0);
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.Write("Input choice :: ");
                int n = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("-------");

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
            _videoStore.ListInventory();
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < _CountOfMovies; i++)
            {
                Console.Write("Enter movie name :: ");
                string movieName = Console.ReadLine();

                Console.Write("Enter rating :: ");
                int rating = Convert.ToInt16(Console.ReadLine());

                _videoStore.AddVideo(movieName);
                _videoStore.TakeUsersRating(rating, movieName);
            }
        }

        private static void RentVideo()
        {
            Console.Write("Enter movie name :: ");
            string movieName = Console.ReadLine();
            _videoStore.Checkout(movieName);
        }

        private static void ReturnVideo()
        {
            Console.Write("Enter movie name :: ");
            string movieName = Console.ReadLine();
            _videoStore.ReturnVideo(movieName);
        }

        public static void TestVideoStore() 
        {
            // test adding videos
            Console.WriteLine("Adding 3 videos:");
            _videoStore.AddVideo("The Matrix");
            _videoStore.AddVideo("Godfather II");
            _videoStore.AddVideo("Star Wars Episode IV: A New Hope");

            // test adding ratings
            _videoStore.TakeUsersRating(7, "The Matrix");
            _videoStore.TakeUsersRating(6, "The Matrix");

            _videoStore.TakeUsersRating(10, "Godfather II");
            _videoStore.TakeUsersRating(9 , "Godfather II");
            _videoStore.TakeUsersRating(2 , "Godfather II");

            _videoStore.TakeUsersRating(8, "Star Wars Episode IV: A New Hope");
            _videoStore.TakeUsersRating(4, "Star Wars Episode IV: A New Hope");

            // test renting
            Console.WriteLine("Renting 3 videos:");
            _videoStore.Checkout("The Matrix");
            _videoStore.Checkout("Godfather II");
            _videoStore.Checkout("Star Wars Episode IV: A New Hope");

            // test returning
            Console.WriteLine("Returning 2 videos:");
            _videoStore.ReturnVideo("The Matrix");
            _videoStore.ReturnVideo("Star Wars Episode IV: A New Hope");

            // test displaying video list
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            _videoStore.ListInventory();

            Console.ReadKey();
        }
    }
}
