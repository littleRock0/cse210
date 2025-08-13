/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string xp) :
        base(name, description, xp)
    {
        
    }
    
    public override void RecordEvent()
    {
        
    }
    
    public override bool IsComplete()
    {
        // I don't actually know if I need this
    }
    
    public override string GetStringRepresentation()
    {
        return "";
    }
}