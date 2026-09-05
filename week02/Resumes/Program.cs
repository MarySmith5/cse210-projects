using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        Job job2 = new Job();

        job1._comany = "Intuit";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2022;
        job1._endYear = 2026;

        job2._comany = "Hairsmith Inc";
        job2._jobTitle = "Owner";
        job2._startYear = 1999;
        job2._endYear = 2022;

        Resume resume = new Resume();

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Mary Smith";
        resume.DisplayResume();
    }
}