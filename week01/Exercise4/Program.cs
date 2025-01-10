using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int numberInput = 893812;
        int largestNumber = 0 ;
        while (true)
        {
            Console.WriteLine("Enter number: ");
            numberInput = int.Parse(Console.ReadLine());
            if (numberInput == 0)
            {
                Console.WriteLine("Computing...");
                break;
            }
            numbers.Add(numberInput);
            foreach (int numeron in numbers)
            {
                if (numeron > largestNumber)
                {
                    largestNumber = numeron;
                }
            }

            
        }
        //Console.WriteLine(numbers.Count);
        int totalSum = numbers.Sum();
        double totalAverage = numbers.Average();
        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {totalAverage}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}