using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void SetAmountCompeted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    
    public override int RecordEvent()
    {
        _amountCompleted += 1;

        int points;

        points = base.GetPoints();

        if (_amountCompleted == _target)
        {
            points += _bonus;
        }

        return points;
    }

    public override bool IsComplete()
    {
        if (_target != _amountCompleted)
        {
            return false;
        }
        
        return true;
    }

    public override string GetDetailsString()
    {
        string name = base.GetName();
        string description = base.GetDescription();

        string detailsString;
        
        if (IsComplete())
        {
            detailsString = $"[X] {name} ({description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        else
        {
            detailsString = $"[ ] {name} ({description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }
        
        return detailsString;
    }

    public override string GetStringRepresentation()
    {
        string name = base.GetName();
        string description = base.GetDescription();
        int points = base.GetPoints();
        
        return $"{name},{description},{points},{_bonus},{_target},{_amountCompleted}";
    }
}