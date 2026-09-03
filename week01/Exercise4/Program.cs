using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num =1;
        List<int> numList = new List<int>();

        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
                numList.Add(num);
            }
        }

        int largest = 0;
        int sum = 0;
        int smPos = 1000000000;

        foreach (int number in numList)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
          
            if (number < smPos && number > 0)
            {
                smPos = number; 
            }
            
        }

        Console.WriteLine($"The sum is: {sum}");
        int count = numList.Count;
        double avg = (double)sum / count; 
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");

        if (smPos != 1000000000)
        {
            Console.WriteLine($"The smallest positive number is: {smPos}");
        }
        else
        {
            Console.WriteLine("You did not enter any positive numbers");
        }

        numList.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int number in numList)
        {
            Console.WriteLine(number);
        }
    }
}