using System;

public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(int numLaps, int durationMin) : base(DateOnly.FromDateTime(DateTime.Now).ToString("dd MMM yyyy"), durationMin)
    {
        _numLaps = numLaps;
        SetDistanceKm(GetDistanceKm(durationMin));
    }

    protected override float GetDistanceKm(int durationMin)
    {
        return _numLaps * 50 / 1000;
    }
}