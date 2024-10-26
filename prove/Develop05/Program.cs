using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        string userChoice;

        int countBreathing = 0;
        int countReflecting = 0;
        int countListing = 0;

        Activity activity = new Activity();
        
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();

                countBreathing ++;
            }

            if (userChoice == "2")
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();

                countReflecting ++;
            }

            if (userChoice == "3")
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();

                countListing ++;
            }

            // Exceeding Requirements: Keeping a log of how many times activities were performed.
            Console.Clear();
            Console.WriteLine("Activity Log:\n");
            
            if (countBreathing == 1)
            {
                Console.WriteLine($"Breathing Activity: {countBreathing} time performed.");
            }
            else
            {
                Console.WriteLine($"Breathing Activity: {countBreathing} times performed.");
            }
            
            if (countReflecting == 1)
            {
                Console.WriteLine($"Reflecting Activity: {countReflecting} time performed.");
            }
            else
            {
                Console.WriteLine($"Reflecting Activity: {countReflecting} times performed.");
            }
            
            if (countListing == 1)
            {
                Console.WriteLine($"Listing Activity: {countListing} time performed.");
            }
            else
            {
                Console.WriteLine($"Listing Activity: {countListing} times performed.");
            }

            activity.ShowSpinner(5);

        } while (userChoice != "4");
    }
}