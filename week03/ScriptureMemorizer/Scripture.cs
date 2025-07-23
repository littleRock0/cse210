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
        
        string[] words;
        
        words = text.Split(" ");
        
        foreach (string word in words)
        {
            Word newWord = new Word(word);
        }
    }
    
    public void HideRandomWords()
    {
        Random number = new Random();
        int numToHide = number.Next(0, _words.Count);
        
        if (!(_words[numToHide].IsHidden()))
        {
            _words[numToHide].Hide();
        }
    }
    
    public string GetDisplayText()
    {
        HideRandomWords();
        
        string reference = _reference.GetDisplayText();
        string wordsFiltered = " ";
        
        foreach (Word word in _words)
        {
            wordsFiltered += word.GetDisplayText();
            wordsFiltered += " ";
        }
        
        return reference + wordsFiltered;
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