using System;

class Program
{
    static void Main(string[] args)
    {
         
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        
        while (true)
        {
            
            Console.Clear();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish");

            
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                
                break;
            }

            
            scripture.HideRandomWords(1);

            
            if (scripture.IsCompletelyHidden())
            {
                
                Console.Clear();
                Console.WriteLine(reference.GetDisplayText());
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending...");
                break;
            }
        }
    }

}