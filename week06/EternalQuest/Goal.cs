using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    protected Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

   protected virtual bool IsComplete()
    {
        return false;
    }

    protected string GetStringRepresentationDetails()
    {
        return $"{_shortName} ({_description})";
    }

    public string GetName()
    {
        return _shortName;
    }

    protected string GetDescription()
    {
        return _description;
    }

    protected int GetPoints()
    {
        return _points;
    }

    public abstract string GetStringRepresentation();
    public abstract string GetDetailsString();

}