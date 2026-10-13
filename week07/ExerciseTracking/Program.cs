using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = [];
        Running run = new Running(6, 30);
        activities.Add(run);
        Cycling bike = new Cycling(10, 30);
        activities.Add(bike);
        Swimming swim = new Swimming(20, 30);
        activities.Add(swim);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}