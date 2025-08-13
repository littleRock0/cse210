/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(int target, int bonus, string name, string
        description, string points) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
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