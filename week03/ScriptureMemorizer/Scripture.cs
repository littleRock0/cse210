/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
    }
    
    public void HideRandomWords(int numToHide)
    {
        if (!(_words[numToHide].IsHidden()))
        {
            _words[numToHide].Hide();
        }
    }
    
    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string wordsFiltered = "";
        
        foreach (Word word in _words)
        {
            wordsFiltered += word.GetDisplayText();
        }
        return "";
    }
    
    public bool IsCompletelyHidden()
    {
        bool allTrue = false;
        
        foreach (Word word in _words)
        {
            return !word.IsHidden() ? allTrue = false && false :
                allTrue = true;
        }
        
        return allTrue;
    }
}