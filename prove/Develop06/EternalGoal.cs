using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        IsComplete();

        return base.GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string name = base.GetName();
        string description = base.GetDescription();
        int points = base.GetPoints();
        
        return $"{name},{description},{points}";
    }
}