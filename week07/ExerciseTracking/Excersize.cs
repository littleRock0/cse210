/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public abstract class Excersize
{
    private string _date;
    private int _duration;
    
    public Excersize(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }
    
    public abstract int GetSpeed();
    
    public abstract float GetDistance();
    
    public abstract int GetPace();
    
    public int GetDuration()
    {
        return _duration;
    }
}