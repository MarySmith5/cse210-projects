using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return GetPoints();
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {GetStringRepresentationDetails()}";
    }

    public override string GetDetailsString()
    {
        return $"EternalGoal:{base.GetName()}|{base.GetDescription()}|{base.GetPoints()}";
    }
}