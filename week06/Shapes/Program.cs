using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine();
        List<Shape> shapes = [];
        Square square = new Square(4, "blue");
        Rectangle rectangle = new Rectangle(2, 4, "red");
        Circle circle = new Circle(3, "yellow");
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
            Console.WriteLine();
        }

    }
}