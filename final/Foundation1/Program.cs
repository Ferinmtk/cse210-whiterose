using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Video video1 = new Video("Video 1 Title", "Author 1", 300);
            Video video2 = new Video("Video 2 Title", "Author 2", 450);
            Video video3 = new Video("Video 3 Title", "Author 3", 120);

            
            video1.AddComment(new Comment("User1", "Great video!"));
            video1.AddComment(new Comment("User2", "Very informative."));
            video1.AddComment(new Comment("User3", "Thanks for sharing."));

            video2.AddComment(new Comment("User4", "Loved the content."));
            video2.AddComment(new Comment("User5", "Awesome video."));
            video2.AddComment(new Comment("User6", "Keep it up!"));

            video3.AddComment(new Comment("User7", "Nice video."));
            video3.AddComment(new Comment("User8", "Learned a lot."));
            video3.AddComment(new Comment("User9", "Amazing!"));

            
            List<Video> videos = new List<Video> { video1, video2, video3 };

            
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
                Console.WriteLine("Comments:");
                
                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
                }
                Console.WriteLine();
            }
        }
    }
}
