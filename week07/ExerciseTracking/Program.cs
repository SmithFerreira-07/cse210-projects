using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        Activity cycling = new Cycling(45, 15.0);

        List<Activity> activites = new List<Activity>();

        activites.Append(cycling);

        foreach (var activity in activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}