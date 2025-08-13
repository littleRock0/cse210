/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class Goal
{
    private string _shortname;
    private string _description;
    private string _points;
    
    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }
    
    public virtual void RecordEvent()
    {
        
    }
    
    public virtual bool IsComplete()
    {
        
    }
    
    public virtual string GetDetailsString()
    {
        
    }
    
    public virtual string GetStringRepresentation()
    {
        
    }
}