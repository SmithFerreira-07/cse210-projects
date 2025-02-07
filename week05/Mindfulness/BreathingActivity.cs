using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Exercise", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        ShowStartingMessage();

        int duration = GetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            
        }

    }
   
}