using System;

public class Activity
{
    private string _date;
    private string _name;
    private int _length;
    private double _distance;
    private double _speed;
    private double _pace;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    
    public int GetLength()
    {
        return _length;
    }
    
    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual double GetSpeed()
    {
        return _speed;
    }

    public virtual double GetPace()
    {
        return _pace;
    }

    public virtual string GetSummary()
    {
        double distance = GetDistance();
        double speed = GetSpeed();
        double pace = GetPace();
        
        return $"{_date} {_name} ({_length} min)- Distance: {distance:0.##} km, Speed: {speed:0.##} kph, Pace: {pace:0.##} km";
    }
}