public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }
    
    public void Run()
    {
        DisplayStartingMessage();

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
        Console.WriteLine("");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {


            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountDown(6);
            //skip the lane to make it look better
            Console.WriteLine("\n \n");
        }

        DisplayEndingMessage(); // I added the message at the end of the loop
        ShowSpinner(5);



    }
}