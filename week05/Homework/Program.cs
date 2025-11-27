using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("Hamza Bouhou", "programming");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();



        MathAssignment mathAssignment1 = new MathAssignment("Hamza Bouhou", "programming", "Section 7.2", "Problem 10-20");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());


        WritingAssignment writingAssignment1 = new WritingAssignment("Hamid Cherkaoui", "AI research", "The dangers of AI");
        Console.WriteLine(writingAssignment1.GetWritingInformation());


    }
}