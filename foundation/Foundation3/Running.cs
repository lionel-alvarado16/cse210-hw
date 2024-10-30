using System;

public class Running : Activity
{
    public Running(string date, int length, double distance) : base(date, length)
    {
        SetName("Running");
        SetDistance(distance);
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        int duration = GetLength();

        double speed = distance / (double)duration * 60;

        return speed;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        int duration = GetLength();

        double pace = (double)duration / distance;
        
        return pace;
    }
}