public interface IShape
{
    double GetArea();
}

public class Square : IShape
{
    public double SideLength { get; set; }

    public double GetArea()
    {
        return SideLength * SideLength;
    }
}

public class Circle : IShape  // Ensure Circle implements IShape
{
    public double Radius { get; set; }

    double IShape.GetArea()  // Explicit implementation for IShape.GetArea
    {
        return Math.PI * Radius * Radius;
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        // Create an array of shapes (can hold objects of different classes implementing IShape)
        IShape[] shapes = new IShape[] { new Square { SideLength = 5 }, new Circle { Radius = 3 } };

        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetType().Name}: {shape.GetArea()}");
        }
    }
}
