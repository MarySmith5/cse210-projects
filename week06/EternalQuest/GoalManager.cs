using System;
using System.IO;
using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals = [];

    private int _score = 0;

    public GoalManager() { }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            choice = GetMenuChoice();
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalNames();
            }
            else if (choice == "3")
            {
                Savegoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else
            {
                Console.WriteLine("Goodbye");
            }
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

    private void ListGoalNames()

    {
        Console.WriteLine("Your goals are:");
        int goalNumber = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{goalNumber}. {goal.GetStringRepresentation()}");
            goalNumber += 1;
        }
    }

    private void AddGoalIfNew(Goal goal)
    {
        foreach (Goal existingGoal in _goals)
        {
            if (existingGoal.GetType() == goal.GetType() &&
                existingGoal.GetName() == goal.GetName())
            {
                return;
            }
        }

        _goals.Add(goal);
    }

    private void CreateGoal()
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
                + " 3. Checklist Goal"
                + Environment.NewLine
                + " 4. Habit-breaking Goal";
            Console.WriteLine(goalMenu);
            Console.Write("Which type of goal would you like to create? ");
            selection = Console.ReadLine();
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the number of points associated with this goal? ");
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
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(goal);
            }
            else if (selection == "4")
            {
                Console.Write("How many points will you be penalized for performing your bad habit? ");
                int penalty = int.Parse(Console.ReadLine());
                HabitBreakingGoal goal = new HabitBreakingGoal(name, description, points, penalty);
                _goals.Add(goal);
            }
            else
            {
                selection = "0";
            }
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal would you like to record? ");
        int index = int.Parse(Console.ReadLine());
        Goal goal = _goals[index - 1];
        int points = goal.RecordEvent();
        _score += points;
        DisplayPlayerInfo();

    }

    private void Savegoals()
    {
        Console.Write("What is the name for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetDetailsString());
            }

        }
    }

    private void LoadGoals()
    {
        Console.Write("What is the name for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        foreach (string line in lines[1..])
        {
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string details = parts[1];
            string[] detailParts = details.Split("|");
            string name = detailParts[0];
            string description = detailParts[1];
            int points = int.Parse(detailParts[2]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(name, description, points);
                AddGoalIfNew(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, description, points);
                AddGoalIfNew(goal);
            }
            else if (goalType == "HabitBreakingGoal")
            {
                HabitBreakingGoal goal = new HabitBreakingGoal(name, description, points, int.Parse(detailParts[3]));
                AddGoalIfNew(goal);
            }
            else
            {
                ChecklistGoal goal = new ChecklistGoal(name, description, points, int.Parse(detailParts[4]), int.Parse(detailParts[3]));
                goal.SetAmountCompleted(int.Parse(detailParts[5]));
                AddGoalIfNew(goal);
            }


        }
    }
}