public class Entry
{


    public string _date; //adding them to hold a piece of data
    public string _prompt;
    public string _entryText;

    public string GetDate()
    {
        DateTime DateTime = DateTime.Now;
        _date = DateTime.ToString("yyyy-MM-dd HH:mm:ss"); // ("d")Short date: "11/6/2025", ("D");  // Long date: "Thursday, November 6, 2025", 
        return _date;
    }

    public string GetRandomPrompt()
    {
        PromptGenerator promptgenerator = new PromptGenerator();
        _prompt = promptgenerator.GetRandomPrompt();

        return _prompt;
    }

    public string GetUserText()
    {
        Console.WriteLine(_prompt);
        Console.Write("What is your entry for that prompt?");

        _entryText = Console.ReadLine();
        return _entryText;
    }
    

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Entry: {_entryText}");
       

    }


}