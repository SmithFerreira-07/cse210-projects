using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberInput = 893812;
        while (true)
        {
            Console.WriteLine("Enter number: ");
            numberInput = int.Parse(Console.ReadLine());
            if (numberInput == 0)
            {
                Console.WriteLine("BREAKING");
                break;
            }
            numbers.Add(numberInput);
            
        }
        Console.WriteLine(numbers.Count);
    }
}