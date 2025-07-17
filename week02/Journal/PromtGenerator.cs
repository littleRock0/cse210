/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        string file = "JournalPrompts.txt";
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
        
        Random number = new Random();
        int promptNum = number.Next(0, lines.Length);
        
        string prompt = _prompts[promptNum];
        
        return prompt;
    }
}