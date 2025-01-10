using System;

class Program
{
    static void Main(string[] args)
    {

        string name = "";
        int numberInt = 920392;
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");

        }
        static string PromptUserName(string name)
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber(int numberInt)
        {
            Console.WriteLine("Please enter your favorite number: ");
            string number = Console.ReadLine();
            numberInt = int.Parse(number);
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
        PromptUserName(name);
        PromptUserNumber(numberInt);
        SquareNumber(numberInt);
        DisplayResult(name, numberInt);
        
    }
}