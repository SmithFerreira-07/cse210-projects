using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Hello user what was your grade percentage?. ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        if (gradeInt >= 90)
        {
            Console.WriteLine("Congratulations! you pass with an A");
        }
        else if (gradeInt >= 80)
        {
            Console.WriteLine("Congratulations! you pass with a B!");
        }
        else if (gradeInt >= 70)
        {
            Console.WriteLine("You passed with a C, you can do better!");
        }
        else if (gradeInt >= 60)
        {
            Console.WriteLine("You got a D, you failed!");
        }
        else if (gradeInt < 60)
        {
            Console.WriteLine("You got a F grade, study harder next time");
        }
    }
}