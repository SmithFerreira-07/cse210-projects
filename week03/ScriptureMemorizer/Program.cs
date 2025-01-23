using System;

class Program
{
    static void Main(string[] args)
    {
         
        ScriptureShelf shelf = new ScriptureShelf();

        shelf.AddScripture(new Scripture(new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        shelf.AddScripture(new Scripture(new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding."));
        shelf.AddScripture(new Scripture(new Reference("Psalm", 23, 1),
            "The Lord is my shepherd I shall not want."));

        
        while (true)
        {
            Scripture scripture = shelf.GetRandomScripture();

            while(true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetReferenceText());
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nPress enter to continue or type 'quit' to change random scripture");

                
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;
                }

                Random random = new Random();
                scripture.HideRandomWords(random.Next(1,3));

                
                if (scripture.IsCompletelyHidden())
                {
                    
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("\nAll words are hidden. Program ending...");
                    break;
                }
            }
            Console.WriteLine("\nDo you want to continue? Type 'quit' to exit or press Enter to continue.");
            string continueInput = Console.ReadLine();
            if (continueInput.ToLower() == "quit")
            {
                break; 
            }
            
        }
    }

}