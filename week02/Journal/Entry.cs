using System;
public class Entry
{

    public string _date;

    public string _response;

    public string _completeEntry;

    PromptGenerator _promptGen;
    public string _prompt;

    public Entry()
    {
        DateTime date = DateTime.Now;
        _promptGen = new PromptGenerator();
        _prompt = _promptGen.GetPrompt();
        _date = date.ToShortDateString();
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