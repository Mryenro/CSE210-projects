using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        int Total = 0;
        int Average = 0;
        int Largest = 0;
        int SmallestPositive = 10000000;
        List<int> numbers = new List<int>();
        do //even number is 0 it will ask user first then proceed to the while loop
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine()); // the typed number is string we need to turn it into int with parse
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("You entered 0, the program now will stop");
            }

        } while (number != 0);

        int NumbersCount = numbers.Count; // use it to calculate average later
        numbers.Sort(); //sorting the list
        foreach (int num in numbers)
        {
            Total = Total + num;
            if (num > Largest) // find the largest number
            {
                Largest = num;
            }
            if (0 < num && num < SmallestPositive)
            {
                SmallestPositive = num;
            }


        }

        Average = Total / NumbersCount;
        

        Console.WriteLine($"Sum is: {Total}");
        Console.WriteLine($"The average is: {Average}");
        Console.WriteLine($"The largest number is: {Largest}");
        Console.WriteLine($"The smallest positive number is: {SmallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers) // write the sorted list
        {
            Console.WriteLine(num);

        }
        


    }
}