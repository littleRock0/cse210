/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public abstract class  Goal
{
    private string _shortname;
    private string _description;
    private string _xp;
    
    public Goal(string name, string description, string xp)
    {
        _shortname = name;
        _description = description;
        _xp = xp;
    }
    
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return "";
    }
    
    public abstract string GetStringRepresentation();
}