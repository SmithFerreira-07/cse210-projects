using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int numberInt = int.Parse(number);
            return numberInt;
        }

        DisplayWelcome();
        PromptUserName();
        PromptUserNumber();
    }
}