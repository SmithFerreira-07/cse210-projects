using System;
using System.Text.Json;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _type = "SimpleGoal";
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == true)
        {
            return $"{_shortName}: {_description} [X]";
        }
        else
        {
            return $"{_shortName}: {_description} [ ]";
        }
        
    }

    public override string GetStringRepresentation()
    {
        return JsonSerializer.Serialize(this);
    }
}