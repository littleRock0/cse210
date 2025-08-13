/***************************************************************************
 * replaced WriteLine with Write to get rid of appended newline character
 * added using static System.Console; to shorten the code
***************************************************************************/
using System;
using static System.Console;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    
    public ChecklistGoal(int target, int bonus, string name, string
        description, string xp) : base(name, description, xp)
    {
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
        
    }
    
    public override bool IsComplete()
    {
        
    }
    
    public override string GetDetailsString()
    {
        
    }
    
    public override string GetStringRepresentation()
    {
        
    }
}