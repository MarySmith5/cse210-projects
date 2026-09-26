using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("Mary Smith", "math");
        assignment1.GetSummary();
        Console.WriteLine();
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodrriquez", "Fractions", "7.3", "8-19");
        mathAssignment1.GetSummary();
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        writingAssignment1.GetSummary();
        Console.WriteLine(writingAssignment1.GetWritinInformation());
    }
}