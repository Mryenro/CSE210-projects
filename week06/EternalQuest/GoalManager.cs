using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public void Start()
    {
        int decision = 0; // decisions to be used later by user
        
        do
        {
            DisplayPlayerScore(); //display score

            //display the menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit\n");
            Console.Write("please choose an activity from the menu, or choose option 6 to quit ");
            decision = int.Parse(Console.ReadLine()); //taking the decision of the user

            if (decision == 1)
            {
                CreateGoal();


            }
            if (decision == 2)
            {
                ListGoalDetails();
            }
            if (decision == 3)
            {
                SaveGoals();
            }
            if (decision == 4)
            {
                LoadGoals();
            }

            if (decision == 5)
            {
                RecordEvent();
            }





        } while (decision != 6);
    }


    public void CreateGoal() //creating the goal (either simple, eternal of checklist goal)
    {
        int goalDecision = 0;
        Console.WriteLine("The types of the goals are: \n 1. Simple Goal. \n 2. Eternal Goal. \n 3. Checklist Goal. \nWhich type of goal would you like to create?");
        goalDecision = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated with this goal?");
        int goalPoints = int.Parse(Console.ReadLine());

        if (goalDecision == 1)//simple goal
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simpleGoal);

        }

        if (goalDecision == 2)//eternal goal
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal);


        }

        if (goalDecision == 3)//checklist goal
        {
            Console.WriteLine("How many times this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());


            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
            _goals.Add(checklistGoal);

        }





    }


    public void ListGoalNames()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetGoalName());
        }
    }

    public void ListGoalDetails()//showing the list of all goals
    {
    
        Console.WriteLine("The goals are: \n");
        for (int i = 0; i < _goals.Count; i++) // Use a loop to number the goals
        {
            Goal goal = _goals[i];

            Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
        }
        Console.WriteLine();
    }


    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int accomplishedGoalint = int.Parse(Console.ReadLine());
        Goal accomplishedGoal = _goals[accomplishedGoalint - 1]; // Convert 1 - based user input to 0 - based index
        accomplishedGoal.RecordEvent();

        int earnedPoints = accomplishedGoal.GetGoalPoints(); //extract the points gained

        if (accomplishedGoal is ChecklistGoal checklistGoal) //if checklist we check if we reached the target, if yes we add the bonus
        {
            if (checklistGoal.IsComplete() && checklistGoal.GetAmountCompleted() == checklistGoal.GetTarget())//use is complete to know if reached the goal, and it makes sure you get it only once.
            {
                earnedPoints += checklistGoal.GetBonus();
                Console.WriteLine();
                Console.WriteLine($"*** Congratulations! You completed this goal and earned a bonus of {checklistGoal.GetBonus()} points in addition to the Goal basic points of {earnedPoints - checklistGoal.GetBonus()} points! ***");
            }

        }
        else if (accomplishedGoal is SimpleGoal simpleGoal) //check if simple goal
        {
            if (simpleGoal.IsComplete())
            {
                Console.Write("You already completed this goal, if you still want to earn the points type 1, otherwise type 2 (or anything else)");
                int earnPointsOrNo = int.Parse(Console.ReadLine());
                if (earnPointsOrNo != 1)
                {
                    Console.WriteLine("Since you already completed this goal before and you chose not to earn the points, no points were added ");
                    //using return to skip the next lines so that it doesnt say anything and doesnt increase the earned points 
                    return;

                }


            }
        }
        


        Console.WriteLine();
        Console.WriteLine($"Congratulations! you have earned {earnedPoints} total points.");
        //update the score
        _score += earnedPoints;
        Console.WriteLine($"Now you have {_score} points. \n \n");


    }

    public void SaveGoals()
    {
        Console.WriteLine("Where do you want to save your goals?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // first line with score
            outputFile.WriteLine(_score);

            // remaining lines with the rest info
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
        Console.WriteLine();
        Console.WriteLine($"Goals saved to {filename}");
        Console.WriteLine();
    }

    public void LoadGoals()
    {

        

        Console.WriteLine("What's the name of the file you want to load from?");
        string filename = Console.ReadLine();

        // Ensure the goals list is cleared before loading new ones
        _goals.Clear();


        string[] lines = System.IO.File.ReadAllLines(filename);//reading all lines from file


        // Try to parse the first line as the score
        if (int.TryParse(lines[0], out int loadedScore))
        {
            _score = loadedScore;
        }
        else
        {
            Console.WriteLine("Error: Could not read score from file.");
            return;
        }

        //now read the rest(goals)


        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];

            // Split the line into the Goal Type and the Goal Data
            string[] parts = line.Split(':', 2); // Split only on the first colon


            string goalType = parts[0];
            string goalData = parts[1];
            string[] dataParts = goalData.Split(','); // Split the data part by comma

            // Extract common properties
            string name = dataParts[0];
            string description = dataParts[1];
            int points = int.Parse(dataParts[2]);

            Goal newGoal = null;

            // Use the goalType to create the correct derived class object
            if (goalType == "SimpleGoal")
            {
                // dataParts indices: 0:name, 1:desc, 2:points, 3:isComplete
                bool isComplete = bool.Parse(dataParts[3]);
                newGoal = new SimpleGoal(name, description, points);
                // Must manually set completion status since it's loaded
                if (isComplete)
                {
                    newGoal.RecordEvent(); // RecordEvent sets _isComplete = true
                }
            }
            else if (goalType == "EternalGoal")
            {
                // dataParts indices: 0:name, 1:desc, 2:points
                newGoal = new EternalGoal(name, description, points);
            }
            else if (goalType == "ChecklistGoal")
            {
                // dataParts indices: 0:name, 1:desc, 2:points, 3:bonus, 4:amountCompleted, 5:target
                int bonus = int.Parse(dataParts[3]);
                int amountCompleted = int.Parse(dataParts[4]);
                int target = int.Parse(dataParts[5]);

                newGoal = new ChecklistGoal(name, description, points, target, bonus);

                // Re-record the event the required number of times
                for (int k = 0; k < amountCompleted; k++)
                {
                    newGoal.RecordEvent();
                }
            }

            // Add the created goal object to the list
            if (newGoal != null)
            {
                _goals.Add(newGoal);
            }
        }

        Console.WriteLine($"Loaded {lines.Length - 1} goals from file. Your score is now {_score}.");
    }




    public void DisplayPlayerScore()
    {
        Console.WriteLine($"You have {_score} points.");
    }






}