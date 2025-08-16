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
        description, int xp) : base(name, description, xp)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    
    public override void RecordEvent()
    {
        
    }
    
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public override string GetDetailsString()
    {
        return $"{_description} --- {_amountCompleted}/{_target}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"{_shortname} ({GetDetailsString()})";
    }
}