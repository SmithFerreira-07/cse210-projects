using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Purple", 10.0);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("Green", 10.0, 20.0);
        shapes.Add(rectangle);
        Circle circle = new Circle("Yellow", 40.0);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} Area: {shape.GetArea():F2} Color: {shape.GetColor()}");
        }
    }

}