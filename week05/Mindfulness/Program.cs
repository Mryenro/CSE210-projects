using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");




        List<string> listingPrompts = new List<string>();
        listingPrompts.Add("Who are people that you appreciate?");
        listingPrompts.Add("What are personal strengths of yours?");
        listingPrompts.Add("Who are people that you have helped this week?");
        listingPrompts.Add("When have you felt the Holy Ghost this month?");
        listingPrompts.Add("Who are some of your personal heroes?");


        List<string> reflectingPrompts = new List<string>();
        reflectingPrompts.Add("Think of a time when you stood up for someone else.");
        reflectingPrompts.Add("Think of a time when you did something really difficult.");
        reflectingPrompts.Add("Think of a time when you helped someone in need.");
        reflectingPrompts.Add("Think of a time when you did something truly selfless.");



        List<string> reflectingQuestions = new List<string>();
        reflectingQuestions.Add("Why was this experience meaningful to you?");
        reflectingQuestions.Add("Have you ever done anything like this before?");
        reflectingQuestions.Add("How did you get started?");
        reflectingQuestions.Add("How did you feel when it was complete?");
        reflectingQuestions.Add("What made this time different than other times when you were not as successful?");
        reflectingQuestions.Add("What is your favorite thing about this experience?");
        reflectingQuestions.Add("What could you learn from this experience that applies to other situations?");
        reflectingQuestions.Add("What did you learn about yourself through this experience?");
        reflectingQuestions.Add("How can you keep this experience in mind in the future?");


        //adding descriptions here to make the program more easy to read 
        string reflectingActivityDes = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        string breathingActivityDes = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string listingActivityDes = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting activity", reflectingActivityDes, 3, reflectingPrompts, reflectingQuestions);




        ListingActivity listingActivity = new ListingActivity("activitty", listingActivityDes, 3, 0, listingPrompts);


        BreathingActivity breathingActivity = new BreathingActivity("Breating activity", breathingActivityDes, 15);

        int decision = 0; //the user decision


        do
        {
            Console.Clear();

            //display the menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("please choose an activity from the menu, or choose option 4 to quit ");
            decision = int.Parse(Console.ReadLine()); //taking the decision of the user

            if (decision == 1)
            {
                breathingActivity.Run();
            }
            if (decision == 2)
            {
                reflectingActivity.Run();
            }
            if (decision == 3)
            {
                listingActivity.Run();
            }


        } while (decision != 4);
    }
}
