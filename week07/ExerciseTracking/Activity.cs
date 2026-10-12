using System;

public abstract class Activity
{
    private DateOnly _date;
    private int _durationMin;
    private int _distanceKm;

    public Activity(DateOnly date, int duration, int distance)
    {
        _date = date;
        _durationMin = duration;
        _distanceKm = distance;
    }

    public abstract int GetDistance();
    public
}