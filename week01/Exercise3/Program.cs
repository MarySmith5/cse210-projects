using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Console.Write("What is the magic number? ");
        // int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Let's play Guess My Number.");
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(1, 100);
        int numGuesses = 0;
        int guess;
        string playAgain = "yes";
        while (playAgain == "yes")
        {
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if (guess > num)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < num)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                numGuesses++;
            } while (guess != num);
            Console.WriteLine($"That took you {numGuesses} guesses.");
            Console.Write("Do you want to play again, yes or no? ");
            playAgain = Console.ReadLine();
            numGuesses = 0;
        }
    }
}