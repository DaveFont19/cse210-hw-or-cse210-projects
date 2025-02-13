using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> _shapes = new List<Shape>();
        Square _square = new Square("white", 13);
        _shapes.Add(_square);

        Circle _circle = new Circle("Red", (float)11.3);
        _shapes.Add(_circle);

        Rectangle _rectangle = new Rectangle("Black", 20, 30);
        _shapes.Add(_rectangle);
        foreach (Shape shape in _shapes)
        {
            Console.WriteLine(shape.GeColor());
            Console.WriteLine(shape.GetArea());
        }


    }
}