using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public void SetIsCompleted(bool isComplete)
    {
        _isComplete = isComplete;
    }
    
    public override int RecordEvent()
    {
        _isComplete = true;

        return base.GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string name = base.GetName();
        string description = base.GetDescription();
        int points = base.GetPoints();
        
        return $"{name},{description},{points},{_isComplete}";
    }
}