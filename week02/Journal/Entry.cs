using System;
public class Entry
{

    public DateTime _date = DateTime.Now;

    public string _response;

    public string _completeEntry;

    PromptGenerator promptGen;
    public string _prompt;

    public Entry()
    {
        promptGen = new PromptGenerator();
        _prompt = promptGen.GetPrompt();
    }

    public string DisplayEntry()
    {
        string entry = $"""
            Date: {_date} -- Prompt: {_prompt}
            {_response}

        """;
        Console.WriteLine(entry);
        return entry;
    }

}