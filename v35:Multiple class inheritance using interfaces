public interface IShape  // Interface for shapes
{
    double GetArea();
    void Draw();
}

public interface IColored  // Interface for color functionality
{
    string Color { get; set; }  // Property for color
}

public class Square : IShape  // Class implementing IShape
{
    public double SideLength { get; set; }

    public double GetArea()
    {
        return SideLength * SideLength;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a square...");
    }
}

public class Circle : IShape  // Class implementing IShape
{
    public double Radius { get; set; }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing a circle...");
    }
}

public class ColoredSquare : Square, IColored  // Class inheriting from Square and implementing IColored
{
    public string Color { get; set; }  // Implementation for color property
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        Square square = new Square { SideLength = 5 };
        Circle circle = new Circle { Radius = 3 };
        ColoredSquare coloredSquare = new ColoredSquare { SideLength = 4, Color = "Red" };

        // Use functionalities through interfaces
        IShape[] shapes = { square, circle };
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"Area of {shape.GetType().Name}: {shape.GetArea()}");
            shape.Draw();
        }

        // Colored shape functionality
        Console.WriteLine($"Colored Square: Area - {coloredSquare.GetArea()}, Color - {coloredSquare.Color}");
    }
}

