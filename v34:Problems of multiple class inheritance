public abstract class Shape  // Abstract class for shapes
{
    public abstract double GetArea();  // Abstract method - must be implemented by derived classes
}

public interface IColorable  // Interface for color functionality
{
    string Color { get; set; }  // Property for color
}

public class Square : Shape, IColorable  // Class inheriting from Shape and implementing IColorable
{
    public double SideLength { get; set; }

    public override double GetArea()
    {
        return SideLength * SideLength;
    }

    public string Color { get; set; }  // Implementation for color property
}

public class Circle : Shape  // Class inheriting from Shape
{
    public double Radius { get; set; }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        // You cannot create an object directly from an abstract class (Shape)
        // Shape shape = new Shape();  // This would cause an error

        Square square = new Square { SideLength = 5, Color = "Red" };
        Circle circle = new Circle { Radius = 3 };

        Console.WriteLine($"Area of Square: {square.GetArea()} (Color: {square.Color})");
        Console.WriteLine($"Area of Circle: {circle.GetArea()}");
    }
}

