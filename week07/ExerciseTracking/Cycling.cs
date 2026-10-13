using System;
using System.Runtime.CompilerServices;

public class Cycling : Activity
{
    private float _speedKph;

    public Cycling(float speedKph, int durationMin) : base(DateOnly.FromDateTime(DateTime.Now).ToString("dd MMM yyyy"), durationMin)
    {
        _speedKph = speedKph;
        SetDistanceKm(GetDistanceKm(durationMin));
    }

    protected override float GetDistanceKm(int durationMin)
    {
        return _speedKph * durationMin / 60;
    }
}