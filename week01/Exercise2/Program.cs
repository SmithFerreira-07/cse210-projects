using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello user what was your grade percentage?. ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);
        string gradeLetter = "";
        if (gradeInt >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeInt >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeInt >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeInt >= 60)
        {
           gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"The grade you got was: {gradeLetter}");

        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed! Good Job");
        }
        else
        {
            Console.WriteLine("You failed study harder next time!");
        }
    }
}