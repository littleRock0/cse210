/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string prompt, string question)
    {
        _prompts.Add(prompt);
        _prompts.Add(question);
    }
    
    public void Run()
    {
        
    }
}