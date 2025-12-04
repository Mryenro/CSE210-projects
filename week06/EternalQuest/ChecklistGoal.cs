public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;



    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;

    }

    public override void RecordEvent()
    {
        ++_amountCompleted;
        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"You already completed this goal {_amountCompleted} times and exceeded the target of {_target} times, you already received the bonus.");
        }
    }


    public override bool IsComplete() //if the amount of time the activity is completed, return true, otherwise false
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public override string GetDetailsString() //same as the main parent class, however we override to add target and update of current completed
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

        return $"{checkBox} {_name} ({_description}) --- Currently completed: {_amountCompleted}/{_target}";


    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_bonus},{_amountCompleted},{_target}";

    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }




}