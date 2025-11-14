using System;
using System.Collections.Concurrent;
//exceeding requirement by trying to get size of scripture according to user choice
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");


        string book = "Ether";
        int chapter = 12;
        int startVerse = 27;
        int endVerse = 29;




        Reference reference = new Reference(book, chapter, startVerse, endVerse); //the scripture I'm going to use is Ether 12:27-29 from the book of mormon

        string scriptureText = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them. Behold, I will show unto you that man's weakness is acceptable unto me if he will repent and come unto me with a full purpose of heart; for I will make weak things become strong unto you. Wherefore, I would not that ye should come unto me save ye humble yourselves.";

        Console.WriteLine($"How many verses from {reference.GetDisplayText()} you want to try to memorize? type 1 for 1 verse, type 2 for all verses: "); //exceeding requirement by trying to get size of scripture according to user choice
        int scriptureLength = int.Parse(Console.ReadLine());

        string verse1 = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them; ";
        string verseRemainings = "Behold, I will show unto the Gentiles their weakness, and I will show unto them that faith, hope and charity bringeth unto me—the fountain of all righteousness; And I, Moroni, having heard these words, was comforted, and said: O Lord, thy righteous will be done, for I know that thou workest unto the children of men according to their faith";
        if (scriptureLength == 1)
        {
            scriptureText = verse1;
        }
        else if (scriptureLength == 2)
        {
            scriptureText = verse1 + verseRemainings;
        }

        


        Scripture scripture = new Scripture(reference, scriptureText);



        //check if it's completely hidden..
        string userInput = "";
        bool IsCompletelyHidden = scripture.IsCompletelyHidden();
        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden()) // the program will continue while the user didnt type quit or all the workds are completely hidden (even if he writes anything else it's fine as long as it's not quit)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();


            scripture.HideRandomWords(3); //hiding random words then starting all over again in the while loop







        }
        //after the while loop  (userInput.ToLower() != quit or IsCompletelyHidden = false)
        if (scripture.IsCompletelyHidden())//when all words are hidden program ends
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("All words are hidden. Program ended.");
        }
        else // If the loop ended because the user typed 'quit'
        {
            Console.Clear();
            Console.WriteLine("Program ended by user request.");
        }

    }
}