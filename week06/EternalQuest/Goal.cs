/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _xp;
    
    public Goal(string name, string description, int xp)
    {
        _name = name;
        _description = description;
        _xp = xp;
    }
    
    public abstract int RecordEvent();
    
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description})";
    }
    
    public abstract string GetStringRepresentation();
    
    public abstract string GetGoalType();
}