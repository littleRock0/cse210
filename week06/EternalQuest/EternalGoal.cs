/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) :
        base(name, description, points)
    {
        
    }
    
    public virtual void RecordEvent()
    {
        
    }
    
    public virtual bool IsComplete()
    {
        
    }
    
    public virtual string GetStringRepresentation()
    {
        
    }
}