using System;

public class JournalOrchestrator
{
    public string _menu = $"""
        Please select one of the following choices: 
        1. Write
        2. Display
        3. Load
        4. Save
        5. Count Blessings
        6. Quit
        Enter the number of your choice: 
        """;

    public Journal _journal = new Journal();

    public JournalOrchestrator() { }

    public void RunJournal()
    {
        int selection = DisplayMenu();
        while (selection != 6)
        {
            OrchestrateSelection(selection);
            selection = DisplayMenu();
        }
        _journal.HandleQuit();
    }

    public void OrchestrateSelection(int selection)
    {
        if (selection == 1)
        {
            _journal.HandleWrite();
        }
        else if (selection == 2)
        {
            _journal.HandleDisplay();
        }
        else if (selection == 3)
        {
            _journal.HandleLoad();
        }
        else if (selection == 4)
        {
            _journal.HandleSave();
        }
        else if (selection == 5)
        {
            _journal.CountBlessings();
        }
        else
        {
            Console.WriteLine("Not a valid selection.");
        }
    }

    public int DisplayMenu()
    {
        Console.Write(_menu);
        return int.Parse(Console.ReadLine());
    }
}