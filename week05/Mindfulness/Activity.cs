using System;

public class Activity
{
    private string _name;

    private string _description;

    private int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void ShowStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine(_description);

        Console.WriteLine("How long in seconds, would you like for your session?: ");
        string choice = Console.ReadLine();
        int choiceInt = int.Parse(choice);
        _duration = choiceInt;
    }
}