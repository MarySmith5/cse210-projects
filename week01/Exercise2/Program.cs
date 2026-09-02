using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr);

        string letter = "F";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }

        int lastDigit = grade % 10;
        string sign = "";
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        string signedLetter;
        if ((grade >= 90 && sign == "+") || grade < 60)
        {
            signedLetter = letter;
        }
        else 
        {
            signedLetter = letter + sign;
        }
  
        Console.WriteLine($"Your grade is {signedLetter}.");


        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Study up! You'll do better next time.");
        }
    }
}