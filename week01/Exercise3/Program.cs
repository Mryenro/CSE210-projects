using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int RandomNumber = randomGenerator.Next(1, 101); //1 included but 101 is not so the last number is 100
        int GuessedNumber = 0;
        string ContinuePlay = "yes";
        int NumberOfGuesses = 0;
        do
        {

            Console.Write("Guess the number: ");
            GuessedNumber = int.Parse(Console.ReadLine());
            NumberOfGuesses = NumberOfGuesses + 1;

            if (GuessedNumber > RandomNumber)
            {
                Console.WriteLine("your guessed a bigger number, try lower");
            }
            else if (GuessedNumber < RandomNumber)
            {
                Console.WriteLine("your guessed a smaller number. try higher");
            }
            else if (RandomNumber == GuessedNumber)
            {
                Console.WriteLine($"you guessed it, the number is {RandomNumber}, you guessed in {NumberOfGuesses} guesses!");
            }
            Console.Write("Do you want to continue playing? Please write yes or no in lower cases ");
            ContinuePlay = Console.ReadLine(); // here unfortunately still didnt learn how to use upper and lower cases yet, and if he uses anything but yes it will stop the loop

            
        } while (RandomNumber != GuessedNumber && ContinuePlay == "yes");


        

    }
}