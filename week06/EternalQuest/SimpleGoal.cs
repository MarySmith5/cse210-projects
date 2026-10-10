using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string completion = "[ ]";
        if (IsComplete())
        {
            completion = "[X]";
        }
        return $"{completion} {base.GetStringRepresentationDetails()}";
    }

    public override string GetDetailsString()
    {
        return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }

}