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
        description, int xp, int amountCompleted = 0) : base(name,
        description, xp)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }
    
    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            
            if (IsComplete())
            {
                return _bonus + _xp;
            }
            else
            {
                return _xp;
            }
        }
        else
        {
            return 0;
        }
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
        return $"{_name} ({GetDetailsString()}) --- " +
            $"{_amountCompleted}/{_target}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"{GetGoalType}:{_name}<|>{_description}<|>{_xp}<|>" +
            $"{_bonus}<|>{_target}<|>{_amountCompleted}";
    }
    
    public override string GetGoalType()
    {
        return "ChecklistGoal";
    }
}