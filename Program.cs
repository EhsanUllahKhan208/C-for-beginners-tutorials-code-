public interface IShape  // Interface for shapes
{
    double GetArea();  // Method to calculate area (abstract)
}

public class Square : IShape  // Square class implementing IShape
{
    public double SideLength { get; set; }

    public double GetArea()
    {
        return SideLength * SideLength;
    }
}

public class Circle : IShape  // Circle class implementing IShape
{
    public double Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        // Create an array of shapes (can hold different shapes implementing IShape)
        IShape[] shapes = new IShape[] { new Square { SideLength = 5 }, new Circle { Radius = 3 } };

        // Calculate area for each shape using polymorphism
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetType().Name}: {shape.GetArea()}");
        }
    }
}

