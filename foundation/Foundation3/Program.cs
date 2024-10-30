using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        List<Activity> activities = new List<Activity>();
        
        activities.Add(new Running("03 Oct 2024", 40, 5.7));
        activities.Add(new Cycling("04 Oct 2024", 30, 20));
        activities.Add(new Swimming("05 Oct 2024", 25, 20));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}