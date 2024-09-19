using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


        // Select the letter grade
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Select the letter sign and handle the exceptional cases
        string sign = "";
        int lastDigit = grade % 10;

        if (lastDigit >= 7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}.");

        // Determine if the user passed the course
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You can do it better the next time. Keep going!");
        }
    }
}