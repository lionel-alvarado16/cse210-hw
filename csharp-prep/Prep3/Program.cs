using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        string again = "Yes";

        while (again == "Yes")
        {
            int guessNumber;
            int i = 0;

            // Console.Write("What is the magic number? ");
            // string userInput = Console.ReadLine();
            // magicNumber = int.Parse(userInput);

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            do
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                i ++;
            } while (guessNumber != magicNumber);

            Console.WriteLine($"You made {i} guesses.");

            Console.Write("Do you want to play again? ");
            again = Console.ReadLine();
        }
    }
}