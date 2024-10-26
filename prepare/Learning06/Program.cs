using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning06 World!");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Green", 2));
        shapes.Add(new Rectangle("Red", 4, 5));
        shapes.Add(new Circle("Yellow", 3));

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}