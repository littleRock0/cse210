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
    
    private ListingActivity(int count)
    {
        _count = count;
    }
    
    private void AddPrompt(string prompt)
    {
        _prompts.Add(prompt);
    }
    
    public void Run()
    {
        
    }
    
    public void GetRandomPrompt()
    {
        
    }
    
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}