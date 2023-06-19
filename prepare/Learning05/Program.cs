using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square("Pink", 2);
        Rectangle s2 = new Rectangle("Purple", 3,4);
        Circle s3 = new Circle("Red", 5);
        List<Shape> shapes = new List<Shape>()
        {
           s1,
           s2,
           s3
        };
        foreach(Shape s in shapes)
        {
            string colour = s.GetColour();
            double area = s.GetArea();
            Console.WriteLine($"The {colour} shapes area is {area}");
        }
        
    }
}