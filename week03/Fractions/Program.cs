using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal 1: {fraction1.GetDecimalValue()}");

        
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal 2: {fraction2.GetDecimalValue()}");

        
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal 3: {fraction3.GetDecimalValue()}");


        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction 4: {fraction4.GetFractionString()}");
        Console.WriteLine($"Fraction 4: {fraction4.GetDecimalValue()}");
    }
}