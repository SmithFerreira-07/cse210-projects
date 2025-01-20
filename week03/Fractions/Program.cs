using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFraction()}");

        
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction 2: {fraction2.GetFraction()}");

        
        Fraction fraction3 = new Fraction(5, 7);
        Console.WriteLine($"Fraction 3: {fraction3.GetFraction()}");
    }
}