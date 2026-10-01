using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        SetDuration();
        Console.WriteLine();
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("Well done!!");
        DisplayPauseSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        DisplayPauseSpinner(5);
    }

    protected string GetRandomPrompt(List<string>prompts)
    {
        int randomIndex = Random.Shared.Next(prompts.Count);
        return prompts[randomIndex];
    }

    protected void DisplayPauseSpinner(int seconds)
    {
        List<string> animations = [];
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    protected void CountDownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    private void SetDuration()
    {
        Console.Write("How long in seconds would you like the duration: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
    }

    protected int GetDuration()
    {
        return _duration;
    }

    
}