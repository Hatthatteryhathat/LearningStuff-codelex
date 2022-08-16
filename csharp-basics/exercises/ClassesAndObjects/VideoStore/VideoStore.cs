using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        List<Video> videoList = new List<Video>();

        public void AddVideo(string title)
        {
            videoList.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            if (videoList.Find(video => video?.Title == title) == null)
            {
                Console.WriteLine($" >> Error: Video by name '{title}' not found!");
            }
            else if (!videoList.Find(video => video?.Title == title).Available())
            {
                Console.WriteLine($" >> Sorry. Video by name '{title}' is allready checked out!");
            }
            else 
            {
                videoList.Find(video => video.Title == title).BeingCheckedOut();
            }
            
            Console.WriteLine("-Press any-key to continnue-");
            Console.ReadKey();
        }

        public void ReturnVideo(string title)
        {
            if (videoList.Find(video => video?.Title == title) == null)
            {
                Console.WriteLine($" >> Error: Video by name '{title}' not found!");
            }
            else if (videoList.Find(video => video?.Title == title).Available())
            {
                Console.WriteLine($" >> Sorry. Video by name '{title}' was not checked out!");
            }
            else 
            {
                videoList.Find(video => video.Title == title).BeingReturned();
                Console.WriteLine("-- Video Returned!");

                Console.Write("Enter video rating(0/10) :: ");
                double rating = double.Parse(Console.ReadLine());
                videoList.Find(video => video.Title == title).ReceivingRating(rating);
            }

            Console.WriteLine("-Press any-key to continnue-");
            Console.ReadKey();
        }

        public void TakeUsersRating(double rating, string title)
        {
            videoList.Find(video => video.Title == title).ReceivingRating(rating);
        }

        public void ListInventory()
        {
            for (int i = 1; i <= videoList.Count; i++) 
            {
                Console.WriteLine($"||{i}. {videoList[i-1].ToString()}");
            }

            if (videoList.Count == 0) 
            {
                Console.WriteLine(" >> Video store empty!");
            }

            Console.WriteLine("-Press any-key to continnue-");
            Console.ReadKey();
        }
    }
}
