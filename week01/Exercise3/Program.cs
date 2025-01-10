using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("What is the magic number?. ");
        string magicString = Console.ReadLine();
        int magicNumber = int.Parse(magicString);
        string answer = "";
        do
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            int guessInt = int.Parse(guess);
            if (guessInt > magicNumber)
            {
                Console.WriteLine("Higher");
                answer = "Higher";
            }
            else if (guessInt < magicNumber)
            {
                Console.WriteLine("Lower");
                answer = "Lower";
            }
            else
            {
                Console.WriteLine("You Guessed It!");
                answer = "Clear";
            }
        }while (answer == "Higher" || answer == "Lower");
    }
}