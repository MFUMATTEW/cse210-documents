using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

         List<Shape> shapes = new List<Shape>();

        Square eSquare = new Square();
        eSquare.SetSide(4);
        eSquare.SetColor ("red"); 

        Rectangle sRectangle = new Rectangle();
        sRectangle.SetColor("orange");
        sRectangle.SetLength(5);
        sRectangle.SetWidth(3);

        Circle eCircle = new Circle();
        eCircle.SetColor("green");
        eCircle.SetRadius(6);

        shapes.Add(eSquare);
        shapes.Add(sRectangle);
        shapes.Add(eCircle);

        foreach (Shape i in shapes)
        {
            double area = i.GetArea();
            string color = i.GetColor();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}