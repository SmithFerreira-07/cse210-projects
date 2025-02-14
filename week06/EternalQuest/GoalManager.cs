using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while(true)
        {
            Console.WriteLine("This is the menu!");
            Console.WriteLine("1. Player Status");
            Console.WriteLine("2. List your Goals");
            Console.WriteLine("3. List your Goal Objectives");
            Console.WriteLine("4. Create your Goal");
            Console.WriteLine("5. Record an Event");
            Console.WriteLine("6. Save your Goals");
            Console.WriteLine("7. Load your Goals");
            Console.WriteLine("8. Close Program");
            string choice = Console.ReadLine();

            switch(choice)
            {
                    
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your Score: {_score}");
    }

    private void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }
    private void CreateGoal()
    {
        Console.WriteLine("Enter your Goal Type");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("");
        string type = Console.ReadLine();
    }

}