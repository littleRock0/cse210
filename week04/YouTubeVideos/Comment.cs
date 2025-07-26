/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Comment
{
    private string _name;
    private string _text;
    
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }
    
    public string GetDisplayText()
    {
        
    }
}