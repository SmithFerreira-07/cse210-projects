using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        Console.WriteLine($"What is the magic number?. {magicNumber}");
        string answer = "";
        do
        {
            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            int guessInt = int.Parse(guess);
            if (guessInt > magicNumber)
            {
                Console.WriteLine("Lower");
                answer = "Lower";
            }
            else if (guessInt < magicNumber)
            {
                Console.WriteLine("Higher");
                answer = "Higher";
            }
            else
            {
                Console.WriteLine($"You Guessed It! the number was {magicNumber}");
                answer = "Clear";
            }
        }while (answer == "Higher" || answer == "Lower");
    }
}