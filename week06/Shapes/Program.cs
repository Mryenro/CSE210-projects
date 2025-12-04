using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square square = new Square("red", 12);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());


        Rectangle rectangle = new Rectangle("blue", 10, 15);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());


        Circle circle = new Circle("yellow", 7);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        Console.WriteLine();
        Console.WriteLine();

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"this is the color: {shape.GetColor()}, and this is the area: {shape.GetArea():F2}");
        }




    }
}