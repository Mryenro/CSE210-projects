using System.Runtime.CompilerServices;

public class Word
{
    private string _text;
    private bool _isHidden;



    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }




    public string GetDisplayText()
    {
        if (_isHidden) //refers to _isHidden = true
        {
            return new string('_', _text.Length); // show underscores instead of letters if the word is hidden using new string() for example: new string('a', 5); will return "aaaaa"
        }
        else
        {
            return _text;
        }
    }

    public void HideWord()
    {
        //hiding the word without changing the core of the word.
        _isHidden = true;

    }

    public void ShowWord()
    {
        _isHidden = false;

    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    

  


}