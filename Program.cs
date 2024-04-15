public class Shape  // Base class
{
    public virtual double CalculateArea()  // Virtual method for area (can be overridden)
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

    public new void CalculateArea()  // Method hiding for circles (no override)
    {
        Console.WriteLine("Circle area calculation logic...");  // Placeholder logic
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        Shape square1 = new Square { SideLength = 5 };
        Shape circle1 = new Circle { Radius = 3 };

        Console.WriteLine("Square Area: {0:0.00}", square1.CalculateArea());  // Overridden method called

        // Circle uses hidden method (no override)
        circle1.CalculateArea();  // Placeholder logic executed

        // Casting to access specific method (optional)
        ((Circle)circle1).CalculateArea();  // This would also call the hidden method
    }
}

