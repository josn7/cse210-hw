using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Top 10 Travel Hacks", "TravelWithMe", 420);
        video1.AddComment(new Comment("Alice", "This is super helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "I use #3 all the time."));
        video1.AddComment(new Comment("Charlie", "Can't wait to try these!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Easy Pasta Recipe", "ChefLuigi", 300);
        video2.AddComment(new Comment("Dana", "Delicious and simple!"));
        video2.AddComment(new Comment("Eli", "I made this for dinner last night."));
        video2.AddComment(new Comment("Fiona", "Yum! Adding this to my rotation."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Workout Routine for Beginners", "FitLife", 600);
        video3.AddComment(new Comment("George", "My legs are sore but thank you!"));
        video3.AddComment(new Comment("Hannah", "Finally something I can keep up with."));
        video3.AddComment(new Comment("Isaac", "Day 1 done o/"));
        videos.Add(video3);

        // Display info
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLengthInSeconds()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.GetCommenterName()}: {comment.GetText()}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}
