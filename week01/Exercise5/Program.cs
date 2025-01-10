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

        static int SquareNumber(int numberInt)
        {
            int square = numberInt * numberInt;
            return square;
        }
        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
        
        
    }
}