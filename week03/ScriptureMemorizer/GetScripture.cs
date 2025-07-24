/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using System.IO;
using static System.Console;

public class GetScripture
{
    private List<string> _scriptures = new List<string>();
    
    public (string, int, int, int, string) GetRandomScripture()
    {
        string file = "Scriptures.txt";
        string[] lines = File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            _scriptures.Add(line);
        }
        
        Random number = new Random();
        int scriptureNum = number.Next(0, lines.Length);
        
        string[] scriptureParts;
        
        string scripture = _scriptures[scriptureNum];
        
        scriptureParts = scripture.Split("|");
        
        string book = scriptureParts[0];
        int chapter = int.Parse(scriptureParts[1]);
        int verse = int.Parse(scriptureParts[2]);
        int endVerse = int.Parse(scriptureParts[3]);
        string text = scriptureParts[4];
        
        return (book, chapter, verse, endVerse, text);
    }
}