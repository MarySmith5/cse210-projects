using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points){}

    public override void recordEvent()
    {
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        string completion = "[ ]";
        if (IsComplete())
        {
            completion = "[X]";
        }
        return $"{completion} {base.GetDetailsString()}";
    }
}