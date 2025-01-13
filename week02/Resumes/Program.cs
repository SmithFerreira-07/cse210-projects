using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        Job job2 = new Job();
        Resume myResume = new Resume();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        Console.WriteLine(myResume._jobs[0]._jobTitle);
        //Console.WriteLine($"{job1._company}, {job2._company}");
        //job1.DisplayJobDetails();
        //job2.DisplayJobDetails();
    }
}