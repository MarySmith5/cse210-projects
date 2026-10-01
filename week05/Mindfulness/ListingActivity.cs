using System;

public class ListingActivity : Activity
{
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];

    private int _count = 0;

    public ListingActivity(): base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){}

    public void Run()
    {
        base.DisplayStartMessage();
        Console.Write("Get ready...");
        base.CountDownTimer(5);
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {base.GetRandomPrompt(_prompts)} ---");
        Console.Write("You may begin in: ");
        base.CountDownTimer(5);
        GetResponses();
        Console.WriteLine();
        DisplayCount();
        Console.WriteLine();
        base.DisplayEndMessage();
    }

    private void GetResponses()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
        }

    }

    private void DisplayCount()
    {
        Console.WriteLine($"You listed {_count} items!");
    }

}