using System;

public class HabitBreakingGoal : Goal
{
    private int _penalty;
    public HabitBreakingGoal(string name, string description, int points, int penalty) : base(name, description, points)
    {
        _penalty = -penalty;
    }

    public override int RecordEvent()
    {
        Console.Write("Did you perform the bad habit today? y or n: ");
        string response = Console.ReadLine().ToLower();
        if (response == "y")
        {
            Console.WriteLine($"You are penalized {_penalty} points.");
            Console.WriteLine("You can do better tomorrow.");
            return _penalty ;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
            return GetPoints();
        }
        
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {GetStringRepresentationDetails()}";
    }

    public override string GetDetailsString()
    {
        return $"HabitBreakingGoal:{GetName()}|{GetDescription()}|{GetPoints()}|_penalty";
    }
}