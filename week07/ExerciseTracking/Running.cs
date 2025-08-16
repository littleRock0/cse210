/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class Running : Excersize
{
    private float _miles;

    public Running(float miles, string date, int duration) : base(date,
        duration)
    {
        _miles = miles;
    }

    public override int GetSpeed()
    {
        int mph = (int)(_miles * (GetDuration() % 60));

        return mph;
    }

    public override float GetDistance()
    {
        return _miles;
    }

    public override int GetPace()
    {
        int pace = (int)(GetDuration() / _miles);

        return pace;
    }
}