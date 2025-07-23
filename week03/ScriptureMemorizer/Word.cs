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
        _text = text;
        _isHidden = false;
    }
    
    public void Hide()
    {
        char[] letters = _text.ToCharArray();
        int i = 0;
        
        if (!_isHidden)
        {
            foreach (char character in letters)
            {
                if (char.IsLetter(character))
                {
                    letters[i] = '_';
                }
                
                i++;
            }
            
            _text = new string(letters);
            _isHidden = true;
        }
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    public string GetDisplayText()
    {
        return _text;
    }
}