using System;
public class Job
{
    public string _comany;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job() {}

    public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_comany}) {_startYear}-{_endYear}");
    }

}