using System;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<Entry> _newEntries = new List<Entry>();
    public PromptGenerator _promptGen;
    public Journal()
    {
        _promptGen = new PromptGenerator();
    }

    public void HandleWrite()
    {
        Entry entry = new Entry();
        Console.WriteLine(entry._prompt);
        Console.Write(">");
        entry._response = Console.ReadLine();
        _newEntries.Add(entry);
        entry.DisplayEntry();
        if (_promptGen._blessingPrompts.Contains(entry._prompt)){
            SaveEntry(entry, "blessings.csv");
        }
    }
    public void HandleDisplay()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        foreach (Entry entry in _newEntries)
        {
            entry.DisplayEntry();
        }

    }

    public void HandleSave()
    {
        Console.Write("Enter your journal csv file name: ");
        string fileName = Console.ReadLine();
        foreach (Entry entry in _newEntries)
        {
            SaveEntry(entry, fileName);
        }

        Console.WriteLine("CSV file saved successfully!");

    }

    public void SaveEntry(Entry entry, String fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, append:true))
        {
            writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
        }
    }

    public void HandleLoad()
    {
        Console.Write("Enter your journal csv file name: ");
        string fileName = Console.ReadLine();
        try
        {
            LoadEntries(fileName);
        }
        catch (Exception e)
        {
            Console.WriteLine("I couldn't find that file.");
        }
    }

    public void LoadEntries(String fileName)
    {
   
        IEnumerable<string> lines = File.ReadLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            entry.DisplayEntry();
            _entries.Add(entry);
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
                SaveEntry(blessingEntry, "blessings.csv");
                Console.WriteLine("Saved your entry!");
            }
        }
    }

    public void HandleQuit()
    {
        Console.WriteLine("See you later!");
    }

}