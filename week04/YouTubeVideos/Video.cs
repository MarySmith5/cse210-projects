using System;
using System.Runtime.InteropServices;

public class Video
{
    private string _title;
    private string _author;
    private double _length;

    private List<Comment> _comments;

    public Video(string title, string author, double sec)
    {
        _title = title;
        _author = author;
        _length = sec;
        _comments = new List<Comment>();
    }

    public void DisplayVideo()

    {
        Console.WriteLine($"{_title} by {_author}, length: {_length}sec.");
        int numComments = CountComments();
        Console.WriteLine($"{numComments} Comments:");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }

    private int CountComments()
    {
        return _comments.Count;
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}