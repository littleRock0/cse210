/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        
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
}