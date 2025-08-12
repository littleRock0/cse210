/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public void DisplaySartingMessage()
    {
        Write($"You have selected {_name}\n\n{_description}\n\n" +
            "How long would you like to spend on this activity" +
            "(in seconds)? ");
        
        _duration = int.Parse(ReadLine());
        
        Clear();
        
        WriteLine("Prepare to begin\n");
        
        ShowSpinner(4);
    }
    
    public void DisplayEndMessage()
    {
        WriteLine("\nWell done!");
        
        ShowSpinner(4);
        
        WriteLine($"\nYou completed another {_duration} seconds of {_name}");
        
        ShowSpinner(4);
    }
    
    public void ShowSpinner(int seconds)
    {
        int loops = (seconds / 2);
        
        for (int i = 0; i < loops; i++)
        {
            Write("|");
            
            Thread.Sleep(500);
            
            Write("\b \b");
            Write("/");
            
            Thread.Sleep(500);
            
            Write("\b \b");
            Write("-");
            
            Thread.Sleep(500);
            
            Write("\b \b");
            Write("\\");
            
            Thread.Sleep(500);
            
            Write("\b \b");
        }
    }
    
    public void ShowCountDown(int seconds)
    {
        int remaining = seconds;
        for (int i = 0; i < seconds; i++)
        {
            Write(remaining);
            
            Thread.Sleep(1000);
            
            Write("\b \b");
            
            remaining -= 1;
        }
        
        Write("\n");
    }
}