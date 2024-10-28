using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        string userInput;

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                CreateGoal();
            }
            
            if (userInput == "2")
            {
                ListGoalDetails();
            }

            if (userInput == "3")
            {
                SaveGoals();
            }

            if (userInput == "4")
            {
                LoadGoals();
            }

            if (userInput == "5")
            {
                RecordEvent();
            }

        } while(userInput != "6");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        
        int i = 0;

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i+1}. {goal.GetName()}");

            i ++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int i = 0;
        
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i+1}. {goal.GetDetailsString()}");

            i++;
        }

        Console.WriteLine();
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userGoalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (userGoalType == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        
        if (userGoalType == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        if (userGoalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userChoice = int.Parse(Console.ReadLine());

        Goal goal = _goals[userChoice - 1];
        int points = goal.RecordEvent();

        _score += points;

        Console.WriteLine($"Congratulations! You have earned {points} points!");
        Console.WriteLine($"You now have {_score} points.\n");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {         
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal}:{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        int i = 1;

        foreach (string line in lines)
        {
            if (i == 1)
            {
                _score = int.Parse(line);
            }

            if (i > 1)
            {
                string[] parts1 = line.Split(":");

                string objectPart = parts1[0];
                string detailsPart = parts1[1];

                string[] parts2 = detailsPart.Split(",");

                string name = parts2[0];
                string description = parts2[1];
                int points = int.Parse(parts2[2]);
                    
                if (objectPart == "SimpleGoal")
                {
                    bool isComplete = bool.Parse(parts2[3]);
                    SimpleGoal sg = new SimpleGoal(name, description, points);
                    sg.SetIsCompleted(isComplete);
                    _goals.Add(sg);
                }

                if (objectPart =="EternalGoal")
                {
                    _goals.Add(new EternalGoal(name, description, points));
                }

                if (objectPart == "ChecklistGoal")
                {
                    int bonus = int.Parse(parts2[3]);
                    int target = int.Parse(parts2[4]);
                    int amountCompleted = int.Parse(parts2[5]);
                    ChecklistGoal ckl = new ChecklistGoal(name, description, points, target, bonus);
                    ckl.SetAmountCompeted(amountCompleted);
                    _goals.Add(ckl);
                }
            }

            i++;
        }
    }
}