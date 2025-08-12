/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description): base(name,
        description)
    {
        
    }
    
    public void Run()
    {
        const int breath = 6;
        int remaining = _duration;
        
        while (remaining >= 12)
        {
            Write("Breath in ...");
            
            ShowCountDown(breath);
            
            remaining -= breath;
            
            Write("Breath out ... ");
            
            ShowCountDown(breath);
            
            remaining -= breath;
        }
        
        if (remaining >= 6)
        {
            Write("Breath in ...");
            
            ShowCountDown(breath);
            
            remaining -= breath;
            
            Write("Breath out ... ");
            
            ShowCountDown(remaining);
        }
        else
        {
            Write("Breath in ...");
            
            ShowCountDown(remaining);
            
            Write("Breath out ... ");
            
            ShowCountDown(3);
        }
        
        return;
    }
}