using System;

public class Comment
{
    private string _commentor;
    private string _text;

    public Comment(string commentor, string text)
    {
        _commentor = commentor;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_text} -- {_commentor}");
    }
}