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
        LoadEntries("blessings.csv");
    }

    public void HandleQuit()
    {
        Console.WriteLine("See you later!");
    }

}