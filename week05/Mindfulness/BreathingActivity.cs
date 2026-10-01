using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") { }
    
    public void Run()
    {
        base.DisplayStartMessage();
        Console.WriteLine("Get ready...");
        base.DisplayPauseSpinner(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            base.CountDownTimer(4);
            Console.Write("Hold...");
            base.CountDownTimer(2);
            Console.Write("Breathe out...");
            base.CountDownTimer(4);

        }
        Console.WriteLine();
        base.DisplayEndMessage();
    }
}