using System;

public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, int length, double laps) : base(date, length)
    {
        SetName("Swimming");
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;

        return distance;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        int duration = GetLength();

        double speed = distance / duration * 60;

        return speed;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        int duration = GetLength();

        double pace = duration / distance;
        
        return pace;
    }
}