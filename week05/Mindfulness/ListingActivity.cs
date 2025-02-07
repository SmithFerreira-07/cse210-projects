using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts;


    public ListingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private int SetGetCount()
    {
        List<string> answersList = GetListFromUser();
        _count = answersList.Count();
        return _count;
    }

    

    private List<string> GetListFromUser()
    {   
        int duration = GetDuration();
        List<string> answers = new List<string>();
        Console.WriteLine("List as many responses you can to the following prompt");
        DateTime finale = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < finale)
        {
            string userInput = Console.ReadLine();
            answers.Add(userInput);
        }
        return answers;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        List<string> answersList = GetListFromUser();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();

    }

}