public class PromptGenerator
{

    public List<string> _prompts  = new List<string>(); 

    public PromptGenerator() //adding many prompts so that the user will certainly have something to say to solve the issue We aren't sure what to write.
    {
        _prompts.Add("What is the most interesting thing I saw or heard today? ");
        _prompts.Add("What is one mistake I made today, and what did I learn from it? ");
        _prompts.Add("How is my energy today / this week? ");
        _prompts.Add("What are the optimal conditions for me to function well today / this week? ");
        _prompts.Add("What did I do today that I am proud of? ");
        _prompts.Add("What emotions in others do I have a difficult time being around, and why? ");
        _prompts.Add("What is one thing I'm grateful for today?  ");
        _prompts.Add("What are three ordinary things that bring me the most joy?  ");
        _prompts.Add("What activities or hobbies bring me joy and fulfillment?  ");
        _prompts.Add("What is a compliment you would like to receive?  ");
        _prompts.Add("What is the biggest challenge I'm facing right now?  ");
        _prompts.Add("What are some potential solutions to the problem or challenge I am facing?  ");
        _prompts.Add("What is one goal I've reached that I'm proud of?  ");
        _prompts.Add("If I had an extra hour today, how would I have spent it?");
        _prompts.Add("What is a difficult conversation I need to have, and what is one thing I will say?");
        _prompts.Add("What is a song, book, or movie that influenced my mood today?");
        _prompts.Add("Where did I feel resistance or procrastination today, and why?");
        _prompts.Add("What small step can I take tomorrow to improve my health?");
        _prompts.Add("What are three words I would use to describe my current state of mind?");
        _prompts.Add("What is a belief I held today that I now want to challenge?");
        _prompts.Add("What is one thing I am looking forward to in the next 24 hours?");
        _prompts.Add("Who is a person I haven't contacted in a while, and why should I reach out?");
        _prompts.Add("What is the biggest lesson I learned this week?");
        _prompts.Add("If my life were a book, what would the title of this chapter be?");
        _prompts.Add("What advice would my future self give me right now?");
        _prompts.Add("Describe a place where I feel most at peace.");
        _prompts.Add("What is something I did purely for fun today?");
        _prompts.Add("How did I show kindness to myself or someone else today?");
        _prompts.Add("If money were no object, what major life change would I make?");
        _prompts.Add("What is a thought that keeps recurring in my mind, and what might it mean?");
        _prompts.Add("What fear did I face, or avoid, today?");
        _prompts.Add("What would be the most meaningful thing I could dedicate my time to next month?");
        _prompts.Add("List three things I accomplished today, no matter how small.");



    }


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }


    


}