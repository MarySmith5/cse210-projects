using System;
//For enrichment, I added a fourth Habitbreaking goal that 
// subracts points when the bad habit is performed that day.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}