using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random rnd = new Random();
        int promptIndex = rnd.Next(_prompts.Count);

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[promptIndex]} ---");
        Console.Write("You may begin in ");
        ShowCountDown(5);
        Console.WriteLine();
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        int duration = GetDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string userInput = Console.ReadLine();
            userList.Add(userInput);
            
            _count ++;
        }

        Console.WriteLine($"You listed {_count} items!");

        return userList;
    }
}