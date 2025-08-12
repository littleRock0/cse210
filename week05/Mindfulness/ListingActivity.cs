/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    
    public ListingActivity(string name, string description) :
        base(name, description)
    {
        _count = 0;
    }
    
    public void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        
        DateTime currentTime = DateTime.Now;
        
        while (currentTime <= futureTime)
        {
            _count++;
        }
        
        return;
    }
    
    public string GetRandomPrompt()
    {
        string file = "ListingPrompts.txt";
        string[] lines = File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            AddPrompt(line);
        }
        
        Random number = new Random();
        int promptNum = number.Next(0, lines.Length);
        
        string prompt = _prompts[promptNum];
        
        return prompt;
    }
}