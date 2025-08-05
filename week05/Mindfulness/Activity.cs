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
    private int _duration;
    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    
    public void DisplaySartingMessage()
    {
        
    }
    
    public void DisplayEndMessage()
    {
        
    }
    
    public void ShowSpinner(int secconds)
    {
        
    }
    
    public void ShowCountDown(int secconds)
    {
        
    }
}