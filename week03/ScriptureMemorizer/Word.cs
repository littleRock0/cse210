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
        static bool isLetter(char chara)
        {
        return true;
        }
        
        char[] letters = _text.ToCharArray();
        int i = 0;
        
        if (!_isHidden)
        {
            foreach (char character in letters)
            {
                if (isLetter(character))
                {
                    letters[i] = '_';
                }
                
                i++;
            }

            _text = new string(letters);
            _isHidden = true;
        }
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
        return _text;
    }
}