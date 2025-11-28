public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {

        _prompts = prompts;
        _questions = questions;
    }

    public string GetRandomPrompt()
    {

        Random random = new Random();
        int randomPromptindex = random.Next(0, _prompts.Count); //random number from 0 to the max prompts number index
        string randomPrompt = _prompts[randomPromptindex];


        return randomPrompt;
    }

    public string GetRandomQuestion()
    {

        Random random = new Random();
        int randomQuestionindex = random.Next(0, _questions.Count); //random number from 0 to the max prompts number index
        string randomQuestion = _questions[randomQuestionindex];
        _questions.Remove(randomQuestion); //remove the question so it's not repeated twice later on

        return randomQuestion;
    }


    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");


    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"> {GetRandomQuestion()} ");
        ShowSpinner(5);
    }

    public void Run()
    {
        DisplayStartingMessage();//beginning like listing activity

        Console.WriteLine("");
        Console.WriteLine("How long in seconds you would like for this session?");



        // Read the input as a string and parse it to int to update _duration
        string durationInput = Console.ReadLine();
        if (int.TryParse(durationInput, out int newDuration)) //make durationInput(the string) into newDuration(int)
        {
            _duration = newDuration;
        }
        Console.Clear();

        Console.Write("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        //while the time isnt over, display the questions
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime && _questions.Count != 0) //when the questions are 0 we stop the loop
        {

            DisplayQuestion();
            if (_questions.Count == 0)
            {
                Console.WriteLine("You are out of questions before the end of the selected time! ");
            }
        }

        DisplayEndingMessage();
        ShowSpinner(5);








    }




}