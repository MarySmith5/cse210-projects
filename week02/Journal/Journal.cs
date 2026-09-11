using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator promptGen;
    public Journal()
    {
        promptGen = new PromptGenerator();
    }

    public void HandleWrite()
    {
        Entry entry = new Entry();
        Console.WriteLine(entry._prompt);
        Console.Write(">");
        entry._response = Console.ReadLine();
        _entries.Add(entry);
        entry.DisplayEntry();
        if (promptGen._blessingPrompts.Contains(entry._prompt)){
            SaveEntry(entry._response, "blessings.csv");
        }
    }
    public void HandleDisplay()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }

    }

    public void HandleSave()
    {
        Console.Write("Enter your journal csv file name: ");
        string fileName = Console.ReadLine();
        foreach (Entry entry in _entries)
        {
            SaveEntry(entry.DisplayEntry(), fileName);
        }

        Console.WriteLine("CSV file saved successfully!");

    }

    public void SaveEntry(String entryData, String fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, append: true))
        {
            writer.WriteLine(string.Join(Environment.NewLine, entryData));
        }
    }

    public void HandleLoad()
    {
        Console.Write("Enter your journal csv file name: ");
        string fileName = Console.ReadLine();
        LoadEntries(fileName);
    }

    public void LoadEntries(String fileName)
    {
        IEnumerable<string> lines = File.ReadLines(fileName);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    public void CountBlessings()
    {
        try
        {
            LoadEntries("blessings.csv");
        }
        catch (Exception e)
        {
            Console.WriteLine("I wasn't able to retrieve any recorded blessings.");
            Console.Write("Would you like to add one now? y/n: ");
            string decsion = Console.ReadLine();
            if (decsion == "y")
            {
                Entry blessingEntry = new Entry();
                blessingEntry._prompt = "How did I see the hand of the Lord in my life today?";
                Console.WriteLine(blessingEntry._prompt);
                Console.Write(">");
                blessingEntry._response = Console.ReadLine();
                SaveEntry(blessingEntry.DisplayEntry(), "blessings.csv");
                Console.WriteLine("Saved your entry!");
            }
        }
    }

    public void HandleQuit()
    {
        Console.WriteLine("See you later!");
    }

}