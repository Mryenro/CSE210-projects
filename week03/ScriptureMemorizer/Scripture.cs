using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

public class Scripture  
{
    private List<Word> _words = new List<Word>(); // create the list
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] rawWords = text.Split(" ", StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.RemoveEmptyEntries removes all the empty spaces or any delimeters declared in the beginning, here we declared spaces " "
        foreach (string wordFromText in rawWords)
        {
            Word word = new Word(wordFromText);
            _words.Add(word);
        }


    }

    public void HideRandomWords(int NumberToHide)
    {
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList(); //this filters all words that are not hidden and puts them in a list VisibleWords, I used here LINQ (Language Integrated Query),
        if (visibleWords.Count == 0)
        {
            return; // All words are already hidden so it will stop
        }

        Random random = new Random();
        int numberOfWordsToHide = Math.Min(Math.Min(visibleWords.Count, 3), NumberToHide); //Math.min(1, 2) this method takes the minimum out of the two numbers, and it can accept only 2 options so here it will take the lowest out of visiblewords, numbertohide 3 and 
        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int index = random.Next(0, visibleWords.Count);
            Word wordToHide = visibleWords[index];
            wordToHide.HideWord(); //we call HideWord from the word class
            // Remove the word from the visible list so it's not selected again in this loop
            visibleWords.RemoveAt(index);
        }    




    }
    


    public string GetDisplayText()
    {   //start with a list that contains all the parts, then join them together with a space in between.
        List<string> displayParts = new List<string>();
        //add the reference.
        displayParts.Add(_reference.GetDisplayText());
        //add all the words
        foreach (Word word in _words)
        {
            displayParts.Add(word.GetDisplayText());
        }

        //add all the parts together in one string but separated with space, we use here string.join
        return string.Join(" ", displayParts);
        
    }
    
    public bool IsCompletelyHidden()
    {
        
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }

        }
        return true;
    }


}