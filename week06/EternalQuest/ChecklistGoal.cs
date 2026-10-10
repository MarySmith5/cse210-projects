using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

    public override int RecordEvent()
    {
        int totalPoints;
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            totalPoints = GetPoints() + _bonus;
            Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
            return totalPoints;
        }
        totalPoints = GetPoints();
        Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
        return totalPoints;
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetStringRepresentation()
    {
        string completion = "[ ]";
        if (IsComplete())
        {
            completion = "[X]";
        }
        return $"{completion} {GetStringRepresentationDetails()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetDetailsString()
    {
        return $"ChecklistGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }
}