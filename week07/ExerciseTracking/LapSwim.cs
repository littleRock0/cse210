/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class LapSwim : Excersize
{
    private int _laps;
    
    public LapSwim(int laps, string date, int duration) : base(date,
        duration)
    {
        _laps = laps;
    }
    
    public override int GetSpeed()
    {
        throw new NotImplementedException();
    }
    
    public override float GetDistance()
    {
        float distance = _laps * 50;
        
        return distance;
    }
}