using System;

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

        }
    }
}