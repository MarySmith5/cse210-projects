using System;

public class Menu
{
    private string _menuString =
    "Menu Options:"
    + Environment.NewLine
    + " 1. Start breathing activity"
    + Environment.NewLine
    + " 2. Start reflecting activity"
    + Environment.NewLine
    + " 3. Start listing activity"
    + Environment.NewLine
    + " 4. Quit";

    private int _choice;

    public void GetMenu()
    {
        Console.WriteLine(_menuString);
    }

    public void OrchestrateMenuChoice(int choice)
    {
        Console.WriteLine();
        if (choice == 1)
        {
            BreathingActivity activity = new BreathingActivity();
            activity.Run();
        }
        else if (choice == 2)
        {
            ReflectionActivity activity = new ReflectionActivity();
            activity.Run();
        }
        else if (choice == 3)
        {
            ListingActivity activity = new ListingActivity();
            activity.Run();
        }

    }

    public int GetChoice()
    {
        Console.Write("Select a choice from the menu: ");
        _choice = int.Parse(Console.ReadLine());
        return _choice;
    }
}