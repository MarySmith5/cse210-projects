using System;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];

    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") { }

    private void GetRandomQuestions()
    {
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());
        string[] questions = _questions.ToArray();
        Random.Shared.Shuffle(questions);
        int i = questions.Count() - 1;
        while (DateTime.Now < endTime && i >= 0)
        {
            Console.Write($"> {questions[i]} ");
            base.DisplayPauseSpinner(10);
            Console.WriteLine();
            i--;
            if (i == -1)
            {
                i = 0;
                Random.Shared.Shuffle(questions);
            }
        }
    }
    
    public void Run()
    {
        base.DisplayStartMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {base.GetRandomPrompt(_prompts)} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.CountDownTimer(5);
        GetRandomQuestions();
        Console.WriteLine();
        base.DisplayEndMessage();
    }
}