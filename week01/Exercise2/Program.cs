using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        string LetterGrade = "";
        int LastDigitGrade = grade % 10; // to check last digit so we can kjnow what is the modifier, < 3 for - and >= 7 for +
        string GradeModifier = "";
        Console.WriteLine(LastDigitGrade);


        if (grade >= 90)
        {
            LetterGrade = "A";

        }



        else if (grade >= 80)
        {
            LetterGrade = "B";
        }

        else if (grade >= 70)
        {
            LetterGrade = "C";
        }
        else if (grade >= 60)
        {
            LetterGrade = "D";
        }
        else
        {
            LetterGrade = "F";
        }



        if (LetterGrade == "B" || LetterGrade == "C" || LetterGrade == "D" && LastDigitGrade >= 7)
        {
            GradeModifier = "+";
        }
        if (LetterGrade == "A" || LetterGrade == "B" || LetterGrade == "C" || LetterGrade == "D" && LastDigitGrade < 3)
        {
            GradeModifier = "-";
        }

        if (grade > 70) // now we print the result
        {
            Console.WriteLine($"Your grade is {LetterGrade}{GradeModifier}, congradulations you pass! ");
        }

        else if (grade < 70)
        {
            Console.WriteLine($"Your grade is {LetterGrade}, unfortunately you didn't pass, good luck next time. ");
        }

    }
    
    
}