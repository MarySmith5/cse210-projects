using System;

public class Running : Activity
{
    private float _distanceKm;
    public Running(int distanceKm, int durationMin) : base(DateOnly.FromDateTime(DateTime.Now).ToString("dd MMM yyyy"), durationMin)
    {
        _distanceKm = distanceKm;
        SetDistanceKm(GetDistanceKm(durationMin));
    }
    
    protected override float GetDistanceKm(int durationMin)
    {
        return _distanceKm;
    }
}