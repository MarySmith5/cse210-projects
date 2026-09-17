using System;

public class Word
{
    private bool _isHidden;
    private string _wordString;

    public Word(string text)
    {
        _isHidden = false;
        _wordString = text;
    }

    public string GetWordText()
    {
        return _wordString;
    }

    public void SetIsHidden(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void HideWord()
    {
        string replacement = "";
        foreach(char letter in _wordString)
        {
            replacement += "_";
        }
        _wordString = replacement;
    }
}