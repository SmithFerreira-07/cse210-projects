using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is the magic number?. ");
        string magicString = Console.ReadLine();
        int magicNumber = int.Parse(magicString);
        Console.WriteLine("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);
        if (magicNumber > guessNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guessNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

    }
}