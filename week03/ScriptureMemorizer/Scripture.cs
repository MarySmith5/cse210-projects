using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    private List<Word> _wordList;
    private List<int> _indexList;

    public Scripture(string reference, string text)
    {
        _wordList = CreateWordList(text);
        _reference = reference;
        _indexList = SetIndexList();
    }

    public List<int> SetIndexList()
    {
        List<int> indexList = Enumerable.Range(0, _wordList.Count).ToList();
        Random rand = new Random();
        int n = indexList.Count;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            int value = indexList[k];
            indexList[k] = indexList[n];
            indexList[n] = value;
        }
        return indexList;
    }

    private List<Word> CreateWordList(string text)
    {
        List<Word> wordList = new List<Word>();
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word(part);
            wordList.Add(word);
        }
        return wordList;
    }

    public void DisplayScripture()
    {
        string scriptureText = "";
        foreach (Word word in _wordList)
        {
            scriptureText += word.GetWordText() + " ";
        }
        Console.WriteLine($"{_reference} {scriptureText}");
    }

    public void UpdateWordList()
    {
        int counter = 0;
        while (counter < 3 && counter < _indexList.Count)
        {
            _wordList[_indexList[0]].HideWord();
            _wordList[_indexList[0]].SetIsHidden(true);
            _indexList.RemoveAt(0);
            counter += 1;
        }
    }
    
    public bool IsWordListAllHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }
        }
        return true;
    }

}