using System;

class Program
{
    static void Main(string[] args)

    {
        Journal newJournal = new Journal();
        int decision = 0;
        do
        {
            Console.WriteLine("Hello World! This is the Journal Project.");
            //display the menu
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            decision = int.Parse(Console.ReadLine()); //taking the decision of the user

            if (decision == 1)
            {

                newJournal.AddEntry();

            }
            else if (decision == 2)
            {
                newJournal.DisplayAll();
            }
            else if (decision == 3)
            {
                newJournal.LoadFromFile();
            }
            else if (decision == 4)
            {
                newJournal.SaveToFile();
            }

        } while (decision != 5);

        Console.WriteLine("You chose to quit, have a nice day!");
        //Entry newEntry = new Entry();
        //newEntry.GetRandomPrompt(); //to add a new random prompt (through Entry then prompt generator)
        //newEntry.GetDate();
        //newEntry.GetUserText();
        //newEntry.DisplayEntry();

    }
}