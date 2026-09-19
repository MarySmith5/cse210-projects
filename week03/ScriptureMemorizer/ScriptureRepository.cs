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
        string[] lines = System.IO.File.ReadAllLines("data.txt");
        foreach (string line in lines)
        {
            Reference reference;
            string[] parts = line.Split("|");
            if (string.IsNullOrEmpty(parts[3]))
            {
                reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
            }
            else
            {
                reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
            }

            Scripture scripture = new Scripture(reference, parts[4]);
            scriptures.Add(scripture);
        }
        return scriptures;

    }


    public Scripture GetAScripture()
    {
        Random randomGenerator = new Random();
        int num = randomGenerator.Next(0, _scriptures.Count);
        return _scriptures[num];
    }


}