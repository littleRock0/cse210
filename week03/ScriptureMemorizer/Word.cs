/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        text = "";
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        int n = 9;
        n++;
    }

    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return "";
    }
}