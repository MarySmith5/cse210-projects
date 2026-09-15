using System;

public class Word
{
    bool _isHidden;
    string _wordString;

    public Word()
    {
        _isHidden = false;
    }

    public void SetWordText(string wordString)
    {
        _wordString = wordString;
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