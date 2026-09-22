using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();
        string[] lines = System.IO.File.ReadAllLines("videoData.txt");
        foreach(string line in lines)
        {
            string[] parts = line.Split("|");
            Video video = new Video(parts[0], parts[1], int.Parse(parts[2]));
            string[] comments = parts[3].Split(",");
            foreach (string comment in comments)
            {
                string[] commentParts = comment.Split("-");
                Comment commentToAdd = new Comment(commentParts[0], commentParts[1]);
                video.AddComment(commentToAdd);
            }
            video.DisplayVideo();
        }
    }
}