public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry newEntry = new Entry();
        newEntry.GetRandomPrompt();
        newEntry.GetDate();
        newEntry.GetUserText();
        newEntry.DisplayEntry();
        _entries.Add(newEntry);


    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine(); // space between entries
        }


    }

    public void SaveToFile()
    {
        Console.Write("What's the name of the file you want to save this journal in? ");
        string fileName = Console.ReadLine();

        // build file content as a big string
        string content = "";
        foreach (Entry entry in _entries)
        {
            content += $"Date: {entry._date}\n"; // \n to jump the line, we could as well add Console.WriteLine(); instead
            content += $"Prompt: {entry._prompt}\n";
            content += $"Entry: {entry._entryText}\n";
            content += "-----------------------------\n";
        }



        // get the project folder path (go up 3 levels from bin/Debug/net8.0)
        string projectPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\.."); //moves three folders up, taking us back to ...week02/Journal instead of \cse210-projects\week02\Journal\bin\Debug\net8.0
        string journalFolder = Path.Combine(projectPath, "Journal");

        string fullPath = Path.Combine(journalFolder, $"{fileName}");
        File.WriteAllText(fullPath, content);

    }



    public void LoadFromFile()//close to savetofile(), we using here File.ReadAllText instead of File.WriteAllText
    {
        Console.Write("What's the name of the file you want to Load ? ");
        string fileName = Console.ReadLine();

        // get the project folder path (go up 3 levels from bin/Debug/net8.0)
        string projectPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\.."); //moves three folders up, taking us back to ...week02/Journal instead of \cse210-projects\week02\Journal\bin\Debug\net8.0
        string journalFolder = Path.Combine(projectPath, "Journal");

        string fullPath = Path.Combine(journalFolder, fileName);

        // check if the file exists
        if (!File.Exists(fullPath))
        {
            Console.WriteLine($"⚠️ File '{fileName}' not found in {journalFolder}");
            return;
        }


        // Read all lines from the file
        string[] lines = File.ReadAllLines(fullPath);

        _entries.Clear(); // remove any old entries in memory

        Entry currentEntry = null;

        foreach (string line in lines)
        {
            if (line.StartsWith("Date: "))
            {
                currentEntry = new Entry();
                currentEntry._date = line.Substring(6); // skip "Date: "
            }
            else if (line.StartsWith("Prompt: "))
            {
                if (currentEntry != null)
                    currentEntry._prompt = line.Substring(8); // skip "Prompt: "
            }
            else if (line.StartsWith("Entry: "))
            {
                if (currentEntry != null)
                    currentEntry._entryText = line.Substring(7); // skip "Entry: "
            }
            else if (line.StartsWith("-----------------------------"))
            {
                if (currentEntry != null)
                {
                    _entries.Add(currentEntry);
                    currentEntry = null;
                }
            }
        }

        Console.WriteLine($"\n Journal '{fileName}' loaded successfully! You can add entries to this current Journal and save same file to replace or a new file");
    }
}

