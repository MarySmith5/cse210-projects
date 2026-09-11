using System;

// For enrichment, I added an option to count your blessings. 
// I save the entries for prompts that show gratitude 
// and return them when option 5 is selected.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        JournalOrchestrator journalRunner = new JournalOrchestrator();
        journalRunner.RunJournal();

    }
}