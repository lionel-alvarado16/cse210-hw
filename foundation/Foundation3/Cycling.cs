using System;

public class Cycling : Activity
{
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        SetName("Cycling");
        SetSpeed(speed);
    }

    public override double GetDistance()
    {
        double speed = GetSpeed();
        int duration = GetLength();

        double distance = speed * duration / 60;

        return distance;
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        int duration = GetLength();

        double pace = duration / distance;
        
        return pace;
    }
}