using System;

public abstract class Activity
{
    private string _date;
    private int _durationMin;
    private float _distanceKm;

    protected Activity(string date, int duration)
    {
        _date = date;
        _durationMin = duration;
    }
    protected void SetDistanceKm(float distanceKm)
    {
        _distanceKm = distanceKm;
    }

    protected abstract float GetDistanceKm(int durationMin);

    protected int GetDuration()
    {
        return _durationMin;
    }
  
    private float GetSpeed()
    {
        return _distanceKm * 60 / _durationMin;
    }

    private float GetPace()
    {
        return _durationMin / _distanceKm;
    }

    public string GetSummary()
    {
        return $"{_date} {GetType()} ({_durationMin} min)- Distance: {_distanceKm:F1} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min/km";
    }

}