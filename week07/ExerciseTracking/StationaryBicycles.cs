/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class StationaryBicycles : Excersize
{
    private int _mph;
    
    public StationaryBicycles(int mph, string date, int duration) : base
        (date, duration)
    {
        _mph = mph;
    }
    
    public override int GetSpeed()
    {
        return _mph;
    }
    
    public override float GetDistance()
    {
        float distance = _mph * GetDuration();
        
        return distance;
    }
}