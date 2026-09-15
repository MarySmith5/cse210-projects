using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

public class ScriptureRepository
{
    private List<Scripture> _scriptures;

    private int _counter;

    public ScriptureRepository()
    {
        _counter = 0;
        _scriptures = LoadScriptures();
    }

    private List<Scripture> LoadScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = System.IO.File.ReadAllLines("data.txt");
        foreach (string line in lines)
        {
            Scripture scripture = new Scripture();
            string[] parts = line.Split("|");
            scripture.SetReference(parts[0]);
            scripture.SetScriptureText(parts[1]);
            scriptures.Add(scripture);
        }
        return scriptures;

    }

    public Scripture GetNextScripture()
    {
        Scripture scripture = _scriptures[_counter];
        _counter += 1;
        return scripture;
    }
    
    public List<Scripture> GetScriptures()
    {
        return _scriptures;
    }

    
}