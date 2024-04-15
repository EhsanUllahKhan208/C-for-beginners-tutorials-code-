public class Shape  // Base class for shapes
{
    public virtual double CalculateArea()  // Virtual method (can be overridden)
    {
        return 0.0;  // Placeholder for derived class implementation
    }
}

public class Square : Shape  // Derived class for squares
{
    public double SideLength { get; set; }

    public override double CalculateArea()  // Override to calculate square area
    {
        return SideLength * SideLength;
    }
}

public class Circle : Shape  // Derived class for circles
{
    public double Radius { get; set; }

    public override double CalculateArea()  // Override to calculate circle area
    {
        return Math.PI * Radius * Radius;
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        Shape square1 = new Square { SideLength = 5 };
        Shape circle1 = new Circle { Radius = 3 };

        Console.WriteLine("Square Area: {0:0.00}", square1.CalculateArea());  // Calls overridden Square.CalculateArea
        Console.WriteLine("Circle Area: {0:0.00}", circle1.CalculateArea());  // Calls overridden Circle.CalculateArea
    }
}
