using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        int Squared = SquareNumber(Number);
        DisplayResult(Name, Squared);

    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");


    }
    static string PromptUserName()
    {
        Console.Write("What's your name? !");
        string Name = Console.ReadLine();
        return Name;

    }
    static int PromptUserNumber()
    {
        Console.Write("What's your favourite number?? !");
        int Number = int.Parse(Console.ReadLine());
        return Number;

    }

    static int SquareNumber(int Number)
    {
        int Squared = Number * Number;
        return Squared;

    }
    
    static void DisplayResult(string Name, int SquareNumber)
    {
        Console.WriteLine($"Brother {Name}, Your square number is {SquareNumber} !");
    }

    
}