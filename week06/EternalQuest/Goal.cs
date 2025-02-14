using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected string _type { get; set; }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _shortName;
    }
}