public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent() //in the simple task, recording the event means it has been completed (needs to be completed only onmce)
    {
    
        _isComplete = true;

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation() 
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";


    }



}