using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        List <int> numbers = new List<int>();

        while (number != 0)
        {       
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int sum = 0;
        int max = -1;
        int min = 99999999; 

        foreach (int num in numbers)
            {
                // Sum the numbers
                
                sum += num;

                // Find the largest number in the list
                if(num > max)
                {
                    max = num;
                }
                
                // Find the smallest positive number
                if(num < min && num >0)
                {
                    min = num;
                }
            }
        
        // Calculate the average
        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");

        // Sort the list of numbers
        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
    }
}