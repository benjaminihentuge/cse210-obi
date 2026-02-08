using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# Basics", "CodeAcademy", 600);
        video1.AddComment(new Comment("John", "Very helpful!"));
        video1.AddComment(new Comment("Mary", "Great explanation."));
        video1.AddComment(new Comment("Alex", "Loved it!"));

        Video video2 = new Video("OOP Explained", "TechWorld", 900);
        video2.AddComment(new Comment("Sarah", "Clear and simple."));
        video2.AddComment(new Comment("Mike", "Now I understand OOP."));
        video2.AddComment(new Comment("Emma", "Excellent video."));

        Video video3 = new Video("Encapsulation in C#", "DevSimplified", 720);
        video3.AddComment(new Comment("Chris", "This helped my assignment."));
        video3.AddComment(new Comment("Nina", "Well structured."));
        video3.AddComment(new Comment("Leo", "Thanks!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments ({video.GetNumberOfComments()}):");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommenterText()}");
            }

            Console.WriteLine();
        }
    }
}
