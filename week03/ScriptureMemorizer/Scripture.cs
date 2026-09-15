using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

public class Scripture
{
    private string _reference;
    private string _scriptureText;
    private List<Word> _wordList;

    public Scripture()
    {
        _wordList = CreateWordList();
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public string GetReference()
    {
        return _reference;
    }

    public void SetScriptureText(string scriptureText)
    {
        _scriptureText = scriptureText;
    }

    public string GetScriptureText()
    {
        return _scriptureText;
    }

    private List<Word> CreateWordList()
    {
        List<Word> wordList = new List<Word>();
        string[] parts = _scriptureText.Split(" ");
        foreach (string part in parts)
        {
            Word word = new Word();
            word.SetWordText(part);
            wordList.Add(word);
        }
        return wordList;
    }

    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference} {_scriptureText}");
    }

    public void UpdateScriptureText()
    {
        Random rand = new Random();
        int counter = 0;
        while (counter < 3)
        {
            int indexNum = rand.Next(0, _wordList.Count);
            _wordList[indexNum].HideWord();
            _wordList[indexNum].SetIsHidden(true);
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