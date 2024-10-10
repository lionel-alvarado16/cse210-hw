using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        Reference reference1 = new Reference("John", 3, 19, 21);
        string scripText1 = "And this is the condemnation, that light is come into the world, and men loved darkness rather than light, because their deeds were evil. For every one that doeth evil hateth the light, neither cometh to the light, lest his deeds should be reproved. But he that doeth truth cometh to the light, that his deeds may be made manifest, that they are wrought in God.";
        
        Reference reference2 = new Reference("Helaman", 5, 12);
        string scripText2 = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";

        List<Scripture> scriptures = [new Scripture(reference1, scripText1), new Scripture(reference2, scripText2)];

        Random randomScripture = new Random();
        int index = randomScripture.Next(scriptures.Count);

        Scripture scripture = scriptures[index]; 

        string userInput;

        do
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                userInput = Console.ReadLine();
                break;
            }

        } while (userInput != "quit");
    }
}