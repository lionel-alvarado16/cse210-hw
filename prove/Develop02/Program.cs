using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");

        string userInput = "";

        do
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            Journal userJournal = new Journal();

            if (userInput == "1")
            {
                userJournal.AddEntry();
            }
            else if (userInput == "2")
            {
                userJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                userJournal.SaveToFile();
            }
            else if (userInput == "4")
            {
                userJournal.LoadFromFile();
            }

        } while (userInput != "5");
    }
}