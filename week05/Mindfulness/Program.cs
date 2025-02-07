using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        while (true)
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select your Activity: ");

            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity activity = new BreathingActivity();
                    activity.Run();
                    break;
                
                case "2":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    return;

                case "3":
                    return;

                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("failure, idk, test");
                    break;
            }

        }
    }
}