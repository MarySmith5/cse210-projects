using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = [];
    private int _score = 0;

    public GoalManager(){}

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            GetMenuChoice();
        }

    }
    
    private string GetMenuChoice()
    {
        Console.WriteLine("Menu Options:"
            + Environment.NewLine
            + " 1. Create New Goal"
            + Environment.NewLine
            + " 2. List Goals"
            + Environment.NewLine
            + " 3. Save Goals"
            + Environment.NewLine
            + " 4. Load Goals"
            + Environment.NewLine
            + " 5. Record Event"
            + Environment.NewLine
            + " 6. Quit");
        Console.Write("Select a choice from the menu: ");
        return Console.ReadLine();

    }
    
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Your goals are:");
        int goalNumber = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetStringRepresentation()}");
            goalNumber += 1;
        }
    }

    public void ListGoalDetails() { }

    public void CreateGoal()
    {
        string selection = "0";
        while (selection == "0")
        {
            string goalMenu =
            "The types of Goals are:"
                + Environment.NewLine
                + " 1. Simple Goal"
                + Environment.NewLine
                + " 2. Eternal Goal"
                + Environment.NewLine
                + " 3. Checklist Goal";
            Console.WriteLine(goalMenu);
            Console.Write("Which type of goal would you like to create?");
            selection = Console.ReadLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the number of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());
            if (selection == "1")
            {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (selection == "2")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (selection == "3")
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonu for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
            }
            else
            {
                selection = "0";
            }
        }
    }

    public void RecordEvent() { }

    public void Savegoals()
    {
        string filename = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

    public void LoadGoals()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }
}