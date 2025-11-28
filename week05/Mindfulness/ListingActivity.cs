public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
    {
        _count = count;
        _prompts = prompts;
    }

    public string GetRandomPrompt() //we return a string so we can display them later if the user wants to
    {

        Random random = new Random();
        int randomPromptIndex = random.Next(0, _prompts.Count); //random number from 0 to the max prompts number index
        string selectedPrompt = _prompts[randomPromptIndex];

        Console.WriteLine($"----{selectedPrompt}----");
        return selectedPrompt;

    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {

            Console.Write("> ");
            string addedPrompt = Console.ReadLine();
            userList.Add(addedPrompt);
            _count++;
        }
        Console.WriteLine($"you listed {_count} items ");
        ShowSpinner(5);

        return userList;



    }
    //exceeding requirement:
    public void DisplayUserList(List<string> userList, string prompt)
    {
        Console.WriteLine("");
        Console.WriteLine("Do you want to display your list with the prompt? type yes or no");
        string decision = Console.ReadLine();
        if ( decision.ToLower() == "yes")
        {
            
            Console.WriteLine("Prompt: ");
            Console.WriteLine(prompt);
            Console.WriteLine("");
            Console.WriteLine("Here is your list: ");
            foreach (string input in userList)
            {
                Console.WriteLine(input);
            }
            ShowSpinner(10);
            Console.Clear();
        }
    }



    public void Run()
    {
        DisplayStartingMessage();//beginning like reflecting activity

        Console.WriteLine("");
        Console.WriteLine("How long in seconds you would like for this session?");

        // Read the input as a string and parse it to int to update _duration
        string durationInput = Console.ReadLine();
        if (int.TryParse(durationInput, out int newDuration))
        {
            _duration = newDuration;
        }
        Console.Clear();



        Console.Write("Get Ready...");
        ShowSpinner(5);
        Console.Clear();

        Console.WriteLine("List as many responses you can to the following prompt:");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine("");

        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        List<string> userList = GetListFromUser();

        Console.Clear();
        DisplayUserList(userList, randomPrompt);
        DisplayEndingMessage();
        ShowSpinner(5);
    }






        
}