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
    
    private ListingActivity(int count, string name, string description,
        int duration) : base(name, description)
    {
        _count = count;
    }
    
    private void AddPrompt(string prompt)
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
            
        }
        
        return;
    }
    
    public void GetRandomPrompt()
    {
        
    }
    
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}