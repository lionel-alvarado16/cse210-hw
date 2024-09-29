using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Welcome to the Journal Program!");

        Journal userJournal = new Journal();

        string userInput = "";

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Entry entry = new Entry();
                userJournal.AddEntry(entry);
            }
            else if (userInput == "2")
            {
                userJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                
                userJournal.LoadFromFile(fileName);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                
                userJournal.SaveToFile(fileName);
            }

        } while (userInput != "5");
    }
}