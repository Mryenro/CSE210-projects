using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your family name? ");
        string family_name = Console.ReadLine();
        Console.WriteLine($"Your name is {family_name}, {first_name} {family_name}.");
    }
}