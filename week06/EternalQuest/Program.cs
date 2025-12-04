using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        List<Goal> _goals = new List<Goal>();
        int score = 0;
        GoalManager goalManager = new GoalManager(_goals, score);
        goalManager.Start();
    }

    //exceeded requirement by adding functionality if the simple goal is completed, and you record it again, you get a message to choose if you get the points or not as you already
    //completed it

    //for checklist goal, not being able to get bonus multiple times but you can record more the checklist, which make eternal and no other bonus in future.
}