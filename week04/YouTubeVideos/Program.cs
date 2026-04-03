using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("Morning Routine", "Emma", 300);
        v1.AddComment(new Comment("Ana", "Loved this video!"));
        v1.AddComment(new Comment("Luis", "So relaxing"));
        v1.AddComment(new Comment("Maria", "Great tips!"));

        // Video 2
        Video v2 = new Video("Workout at Home", "Carlos", 600);
        v2.AddComment(new Comment("Jose", "Very helpful!"));
        v2.AddComment(new Comment("Sofia", "I will try this"));
        v2.AddComment(new Comment("Miguel", "Nice exercises"));

        // Video 3
        Video v3 = new Video("Study Tips", "Laura", 400);
        v3.AddComment(new Comment("Pedro", "This helped me a lot"));
        v3.AddComment(new Comment("Lucia", "Thanks!"));
        v3.AddComment(new Comment("Andres", "Good advice"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}