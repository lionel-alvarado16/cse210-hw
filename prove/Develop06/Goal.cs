using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    
    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
    
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string detailsString;
        
        if (IsComplete())
        {
            detailsString = $"[X] {_shortName} ({_description})";
        }
        else
        {
            detailsString = $"[ ] {_shortName} ({_description})";
        }
        
        return detailsString;
    }

    public abstract string GetStringRepresentation();
}