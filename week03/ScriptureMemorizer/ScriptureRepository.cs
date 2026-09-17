using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

public class ScriptureRepository
{
    private List<Scripture> _scriptures;

    public ScriptureRepository()
    {
        _scriptures = LoadScriptures();
    }

    private List<Scripture> LoadScriptures()
    {
        List<Scripture> scriptures = new List<Scripture>();
        string[] lines = System.IO.File.ReadAllLines("data copy.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Scripture scripture = new Scripture(parts[0], parts[1]);
            scriptures.Add(scripture);
        }
        return scriptures;

    }
    
    public List<Scripture> GetScriptures()
    {
        return _scriptures;
    }

    
}