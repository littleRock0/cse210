/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int xp) :
        base(name, description, xp)
    {
        
    }
    
    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            return _xp;
        }
        else
        {
            return 0;
        }
    }
    
    public override bool IsComplete()
    {
        return false;
    }
    
    public override string GetStringRepresentation()
    {
        return $"{GetGoalType()}<|>{_name}<|>{_description}<|>{_xp}<|>";
    }
    
    public override string GetGoalType()
    {
        return "EternalGoal";
    }
}