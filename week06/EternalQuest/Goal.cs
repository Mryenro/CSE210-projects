using System.Runtime.InteropServices.Marshalling;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
    public virtual string GetDetailsString() //virtual because it will be overriden only at checklist goal, and there is a default method
    {
        string checkBox = "";
        if (IsComplete() == true)
        {
            checkBox = "[x]";
        }
        else
        {
            checkBox = "[ ]";
        }


        return $"{checkBox} {_name} ({_description})";
    }

    public abstract string GetStringRepresentation();


    public virtual string GetGoalName()
    {
        return _name;
    }

    public virtual int GetGoalPoints()
    {
        return _points;
    }






}