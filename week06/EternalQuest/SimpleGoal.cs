/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class SimpleGoal : Goal
{
    private bool _iscomplete;
    
    public SimpleGoal(string name, string description, string xp) :
        base(name, description, xp)
    {
        
    }
    
    public override void RecordEvent()
    {
        
    }
    
    public override bool IsComplete()
    {
        return _iscomplete;
    }
    
    public override string GetStringRepresentation()
    {
        return "";
    }
}