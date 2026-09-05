using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        double numSq = SquareNumber(num);
        DisplayResult(name, numSq);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static double SquareNumber(int num)
    {
        return Math.Pow(num, 2);
    }

    static void DisplayResult(string name, double numSq)
    {
        Console.WriteLine($"{name} the square of your number is {numSq}");
    }
    

}